using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviour
{
    private static  NetworkManager _instance;
    public static NetworkManager Instance{get{return _instance;}}

    public String Host = "raspberrypi.local"; // 127.0.0.0 -- 127.0.0.1 = localhost
    public Int32 Port = 55000;
       
    TcpClient mySocket = null;
    NetworkStream theStream = null;
    StreamWriter theWriter = null;
    Image connectionStatus;
    bool connected;
    public GameObject toggleSwitch;
  
    public void Awake(){
        if(_instance == null){
            _instance = this;
        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        
        connectionStatus = GameObject.Find("ConnectionStatus").GetComponent<Image>();
        connectionStatus.color = Color.red;
        mySocket = new TcpClient();
        
    }
    public bool SetupSocket()
    {
        try
        {
            mySocket.Connect(Host, Port);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if(toggleSwitch.GetComponent<ToggleController>().GetState() == true){
            if (!mySocket.Connected)
            {
                connected = false;
                SetupSocket();
            }
            else
            {
                connected = true;
                connectionStatus.color = Color.green;

            }
        }
       
    }
    public bool GetConnectionStatus(){
        if(toggleSwitch.GetComponent<ToggleController>().GetState() == true){
            return connected;
        }
        else{
            return false;
        }
    }  

    public void Send(Byte[] sendBytes){
        if(toggleSwitch.GetComponent<ToggleController>().GetState() == true){
            theStream = mySocket.GetStream();
            try
            {
                theStream.Write(sendBytes, 0, sendBytes.Length);
            }
            catch (SocketException e )
            {
                Debug.Log("socket error");
            }
        }
    }


    void OnApplicationQuit()
    {
        if (mySocket != null && mySocket.Connected)
            mySocket.Close();
    }
   

  
}

