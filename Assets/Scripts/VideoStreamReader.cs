using UnityEngine;
using System.Collections;
 
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;
public class VideoStreamReader : MonoBehaviour
{
    // texture that will load the bytes
    private Texture2D tex;
    private RawImage rawImage;

     // receiving Thread
    Thread receiveThread;
    private TcpClient client = null;
    private NetworkStream theStream = null;
    // public
    public String Host = "192.168.2.1";   //default local
    public int port = 5600;           // define port 
 
    // infos
    public string lastReceivedUDPPacket="";
    public string allReceivedUDPPackets=""; // clean up this from time to time!

    void Awake(){
        rawImage = GameObject.Find("VideoStream").GetComponent<RawImage>();
        UnityThread.initUnityThread();


    }
    // Start is called before the first frame update
    void Start()
    {
        tex = new Texture2D(2, 2);
        client = new TcpClient();
        client.Connect(Host, port);

        theStream = client.GetStream();
     
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     // receive thread
    private void ReceiveData()
    {
        try { 			
            Byte[] bytes = new Byte[1024];             
            while (true) { 				
                // Get a stream object for reading 				
                using (NetworkStream stream = client.GetStream()) { 					
                    int length; 					
                    // Read incomming stream into byte arrary. 					
                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0) { 						
                        var data = new byte[length]; 						
                        Array.Copy(bytes, 0, data, 0, length); 						
                        // Convert byte array to string message. 						
                        string serverMessage = Encoding.ASCII.GetString(data); 						
                        Debug.Log("server message received as: " + serverMessage); 	
                        UnityThread.executeInUpdate(() =>
                        {
                            if (data[0] == 255 && data[1] == 216 && data[2] == 255 && data[3] == 224 && data[4] == 0 && data[5] == 16 && data[6] == 74 && data[7] == 70 && data[8] == 73 && data[9] == 70)
                            {
                                //UnityEngine.Debug.Log("* texture *");
                                tex.LoadImage(data);
                                rawImage.material.mainTexture = tex;  

                            }       
                        
                        });				
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
        if ( receiveThread!= null)
            receiveThread.Abort();

        client.Close();
    }
}
