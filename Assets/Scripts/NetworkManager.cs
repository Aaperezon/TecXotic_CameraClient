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
    RemoteController controller;
    ControllerValue controllerValue = new ControllerValue();

    void Awake()
    {
        controller = new RemoteController();
        controller.CameraVideo.ShowHide.performed += ctx => controllerValue.show_hide = true;
        controller.CameraVideo.ShowHide.canceled += ctx => controllerValue.show_hide = false;
    }

    void OnEnable(){
        controller.CameraVideo.Enable();
    }
     void OnDisable(){
        controller.CameraVideo.Disable();
    }



    // Start is called before the first frame update
    void Start()
    {
        connectionStatus = GetComponent<Image>();
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
    void Update()
    {
        if (!mySocket.Connected)
        {
            SetupSocket();
        }
        else
        {
            SendData();
        }
    }



    void OnApplicationQuit()
    {
        if (mySocket != null && mySocket.Connected)
            mySocket.Close();
    }
   

    private void SendData()
    {

        string json = JsonUtility.ToJson(controllerValue);
        theStream = mySocket.GetStream();
        Byte[] sendBytes = System.Text.Encoding.UTF8.GetBytes(json);
        try
        {
            theStream.Write(sendBytes, 0, sendBytes.Length);
        }
        catch (SocketException e )
        {
            Debug.Log("socket error");

        }
        connectionStatus.color = Color.green;




    }
}


[Serializable]
public class ControllerValue
{
    public string Name;
    public bool show_hide = false;
}

