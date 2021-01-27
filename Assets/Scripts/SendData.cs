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

        controller.Controller.ArmDisarm.performed += ctx => controllerValue.arm_disarm = true;
        controller.Controller.ArmDisarm.canceled += ctx => controllerValue.arm_disarm = false;

        controller.Controller.PixyLight.performed += ctx => controllerValue.pixyLight = true;
        controller.Controller.PixyLight.canceled += ctx => controllerValue.pixyLight = false;

        controller.Controller.Throttle.performed += ctx => controllerValue.throttle = (int)(ctx.ReadValue<float>()*500)+500;
        controller.Controller.Throttle.canceled += ctx => controllerValue.throttle = 500;

        controller.Controller.Pitch.performed += ctx => controllerValue.pitch = (int)(ctx.ReadValue<float>()*1000);
        controller.Controller.Pitch.canceled += ctx => controllerValue.pitch = 0;

        controller.Controller.Roll.performed += ctx => controllerValue.roll = (int)(ctx.ReadValue<float>()*1000);
        controller.Controller.Roll.canceled += ctx => controllerValue.roll = 0;

        controller.Controller.Yaw.performed += ctx => controllerValue.yaw = (int)(ctx.ReadValue<float>()*1000);
        controller.Controller.Yaw.canceled += ctx => controllerValue.yaw = 0;

    }

    void OnEnable(){
        controller.Controller.Enable();
    }
     void OnDisable(){
        controller.Controller.Disable();
    }

    void Start()
    {
    }

    void Update()
    {
        try{
            if(NetworkManager.Instance.GetConnectionStatus() == true){
                Send();
            }
        }
        catch(NullReferenceException e){

        }
        catch(Exception e){
           Debug.Log(e); 
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
    public bool arm_disarm;
    public int throttle = 500;
    public int roll;
    public int pitch;
    public int yaw;
    public bool pixyLight;

}
