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
public class SendData : MonoBehaviour
{
    RemoteController controller;
    ControllerValue controllerValue = new ControllerValue();


    void Awake()
    {
        controller = new RemoteController();
        controller.CameraVideo.PixyLight.performed += ctx => controllerValue.pixyLight = true;
        controller.CameraVideo.PixyLight.canceled += ctx => controllerValue.pixyLight = false;
    }

    void OnEnable(){
        controller.CameraVideo.Enable();
    }
     void OnDisable(){
        controller.CameraVideo.Disable();
    }

    void Start()
    {
        NetworkManager.Instance.Start();
    }

    void Update()
    {
        NetworkManager.Instance.Update();
        if(NetworkManager.Instance.GetConnectionStatus() == true){
            Send();
        }
        
    }
    void Send()
    {
        string json = JsonUtility.ToJson(controllerValue);
        Byte[] sendBytes = System.Text.Encoding.UTF8.GetBytes(json);
        try{
            NetworkManager.Instance.Send(sendBytes);
        }
        catch (SocketException e)
        {
            Console.WriteLine("{0} Error code: {1}.", e.Message, e.ErrorCode);
        }
    }
}


[Serializable]
public class ControllerValue
{
    public string Name;
    public bool pixyLight = false;
}
