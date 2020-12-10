using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.Analytics;
using UnityEngine.InputSystem;

public class NetworkManager : MonoBehaviour
{
    public String Host = "raspberrypi.local";
    public Int32 Port = 55000;
       
    TcpClient mySocket = null;
    NetworkStream theStream = null;
    StreamWriter theWriter = null;
    Image connectionStatus;
    bool connected;
  


    // Start is called before the first frame update
    public void Start()
    {
        connectionStatus = GameObject.Find("ConnectionStatus").GetComponent<Image>();
        connectionStatus.color = Color.red;
        mySocket = new TcpClient();
        if (SetupSocket())
        {
            Debug.Log("socket is set up");
        }
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
    public bool GetConnectionStatus(){
        return connected;
    }  

    public void Send(Byte[] sendBytes){
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


    void OnApplicationQuit()
    {
        if (mySocket != null && mySocket.Connected)
            mySocket.Close();
    }
   

  
}

