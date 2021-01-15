using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Collections;
using System.Threading;

public class NetworkManager : MonoBehaviour
{
    private static  NetworkManager _instance;
    public static NetworkManager Instance{get{return _instance;}}
    private static Thread clientReceiveThread; 	


    public String Host = "raspberrypi.local"; // 127.0.0.0 -- 127.0.0.1 = localhost
    public Int32 Port = 55000;
    private static TcpClient mySocket = null;
    private static NetworkStream theStream = null;
    private static Image connectionStatus;
    public GameObject toggleSwitch;
  

    void OnEnable()
    {
        if(_instance == null){
            _instance = this;
        }

        Debug.Log("Setting up network...");
        String message = "";
        connectionStatus = GameObject.Find("ConnectionStatus").GetComponent<Image>();
        connectionStatus.color = Color.red;
        mySocket = new TcpClient();
        //SET UP SOCKET CONNECTION
        try
        {
            mySocket.Connect(Host, Port);
            theStream = mySocket.GetStream();
            connectionStatus.color = Color.green;
            message+="Connection ready to write";

        }
        catch (Exception e)
        {
            Debug.Log(e);

            message+="Connection NOT ready to write";

        }
        try {  			
			clientReceiveThread = new Thread (new ThreadStart(Receive)); 			
			clientReceiveThread.IsBackground = true; 			
			clientReceiveThread.Start();  
            message+=" and ready to read";
		} 		
		catch (Exception e) { 			
            message+=" and NOT ready to read";
		} 	

        Debug.Log(message);


    }

    public bool GetConnectionStatus(){
        try{
            return mySocket.Connected;
        }
        catch(Exception e){
            return false;
        }
    }  
    public void Send(Byte[] sendBytes){
         if(toggleSwitch.GetComponent<ToggleController>().GetState() == true){
                //Debug.Log("Primero manda");
            try
            {

                theStream.Write(sendBytes, 0, sendBytes.Length);
            }
            catch (SocketException e )
            {
                Debug.Log("socket Sending error");
            }
        }
    }
    public void Receive(){
        //Debug.Log("Despues Recibe");
        try { 			
            Byte[] bytes = new Byte[1024];             
            while (true) { 				
                // Get a stream object for reading 				
                using (NetworkStream stream = mySocket.GetStream()) { 					
                    int length; 					
                    // Read incomming stream into byte arrary. 					
                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0) { 						
                        var incommingData = new byte[length]; 						
                        Array.Copy(bytes, 0, incommingData, 0, length); 						
                        // Convert byte array to string message. 						
                        string serverMessage = Encoding.ASCII.GetString(incommingData); 						
                        Debug.Log("server message received as: " + serverMessage); 					
                    } 				
                } 			
            }         
        }         
        catch (SocketException socketException) {             
            Debug.Log("Socket exception: " + socketException);         
            Debug.Log("Error trying to read..." );         
        }  
    }

    

    void OnDisable()
    {
        if (mySocket != null && mySocket.Connected)
        {
            mySocket.Close();
            Debug.Log("Connection ended...");
            connectionStatus.color = Color.red;
            
        }

        if(_instance != null){
            _instance = null;
        }
        

    }

    void OnApplicationQuit()
    {
        if (mySocket != null && mySocket.Connected){
            mySocket.Close();
            Debug.Log("Connection closed...");
            
        }
        if(_instance != null){
            _instance = null;
        }

    }
   

  
}

