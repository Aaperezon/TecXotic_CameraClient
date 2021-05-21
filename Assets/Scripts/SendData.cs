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
    private static RemoteController controller;
    private static ControllerValue controllerValue = new ControllerValue();

    public static ControllerValue GetSender(){
        return controllerValue;
    }
    public static RemoteController GetController(){
        return controller;
    }

    void Awake()
    {
        controller = new RemoteController();

        controller.Controller.ArmDisarm.performed += ctx => controllerValue.arm_disarm = ChangeArmDisarm(true);
        controller.Controller.ArmDisarm.canceled += ctx => controllerValue.arm_disarm = ChangeArmDisarm(false);

        controller.Controller.FlightMode.performed += ctx => controllerValue.flight_mode = ChangeFlightMode(true);
        controller.Controller.FlightMode.canceled += ctx => controllerValue.flight_mode = ChangeFlightMode(false);

        controller.Controller.PixyLight.performed += ctx => controllerValue.light = true;
        controller.Controller.PixyLight.canceled += ctx => controllerValue.light = false;

        controller.Controller.Throttle.performed += ctx => controllerValue.throttle = (int)(ctx.ReadValue<float>()*500)+500;
        controller.Controller.Throttle.canceled += ctx => controllerValue.throttle = 500;

        controller.Controller.Pitch.performed += ctx => controllerValue.pitch = (int)(ctx.ReadValue<float>()*1000);
        controller.Controller.Pitch.canceled += ctx => controllerValue.pitch = 0;

        controller.Controller.Roll.performed += ctx => controllerValue.roll = (int)(ctx.ReadValue<float>()*1000);
        controller.Controller.Roll.canceled += ctx => controllerValue.roll = 0;

        controller.Controller.Yaw.performed += ctx => controllerValue.yaw = (int)(ctx.ReadValue<float>()*1000);
        controller.Controller.Yaw.canceled += ctx => controllerValue.yaw = 0;

    }
   
   
    bool button1Aux = false;
    private int selectorFlightMode=-1;
    private string[] flightModes = new string[]{"MANUAL","STABILIZE","ACRO"};
    private string ChangeFlightMode(bool state){
        if(state == true && button1Aux == false){
            if(selectorFlightMode >= 2){
                selectorFlightMode=-1;
            }
            selectorFlightMode++;
            button1Aux = true;
        }
        else if (state == false){
            button1Aux = false;
        }
        return flightModes[selectorFlightMode];
        
    }
    bool button2Aux = false;
    private bool[] armModes = new bool[]{true,false};
    private int selectorarmMode=-1;


    private bool ChangeArmDisarm(bool state){
        if(state == true && button2Aux == false){
            if(selectorarmMode >= 1){
                selectorarmMode=-1;
            }
            selectorarmMode++;
            button2Aux = true;
        }
        else if (state == false){
            button2Aux = false;
        }
        return armModes[selectorarmMode];    
    }
    void OnEnable(){
        controller.Controller.Enable();
    }
     void OnDisable(){
        controller.Controller.Disable();
    }
    GameObject armedIndicator;
    GameObject flightMode;
    GameObject agent1;
    GameObject agent2;
    GameObject agent3;
    GameObject agent4;
    GameObject agent5;
    void Start()
    {
        armedIndicator = GameObject.Find("ArmedIndicator");
        flightMode = GameObject.Find("FlightMode");
        agent1 = GameObject.Find("Agent1");
        agent2 = GameObject.Find("Agent2");
        agent3 = GameObject.Find("Agent3");
        agent4 = GameObject.Find("Agent4");
        agent5 = GameObject.Find("Agent5");
    }
   
    void Update()
    {
        string json = JsonUtility.ToJson(controllerValue);
        Debug.Log(json);
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
        Indicators();
        
    }

    private void Indicators(){
        armedIndicator.SendMessage("Set", controllerValue.arm_disarm);
        flightMode.SendMessage("Set", controllerValue.flight_mode);
        agent1.SendMessage("Set", controllerValue.activate_agent1);
        agent2.SendMessage("Set", controllerValue.activate_agent2);
        agent3.SendMessage("Set", controllerValue.activate_agent3);
        agent4.SendMessage("Set", controllerValue.activate_agent4);
        agent5.SendMessage("Set", controllerValue.activate_agent5);
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
    public bool arm_disarm = false;
    public string flight_mode = "MANUAL";
    public bool light = false;


    public int throttle = 500;
    public int roll = 0;
    public int pitch = 0;
    public int yaw = 0;

    public int agent3_x = 0;
    public int agent3_y = 0;
    public float agent3_w = 200;
    public float agent3_h = 150;
    public bool agent3_shoot = false;
    public bool activate_agent1 = false;
    public bool activate_agent2 = false;
    public bool activate_agent3 = true;
    public bool activate_agent4 = false;
    public bool activate_agent5 = false;

}
