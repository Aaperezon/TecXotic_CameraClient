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

        controller.Controller.CameraPitchUp.performed += ctx => controllerValue.pitch_camera = ChangePitchCamera(controllerValue.pitch_camera, 2);
        controller.Controller.CameraPitchDown.performed += ctx => controllerValue.pitch_camera = ChangePitchCamera(controllerValue.pitch_camera, -2);
        
        controller.Controller.ConnectPixhawk.performed += ctx => controllerValue.connect_pixhawk = ChangeConnectPixhawk(true);
        controller.Controller.ConnectPixhawk.canceled += ctx => controllerValue.connect_pixhawk = ChangeConnectPixhawk(false);

        controller.Controller.MiniROV_forward.performed += ctx => {
            pressed1 = true;
            controllerValue.miniROV_direction = ChangeMiniROVDirection("f");
        };
        controller.Controller.MiniROV_forward.canceled += ctx => {
            pressed1 = false;
            controllerValue.miniROV_direction = ChangeMiniROVDirection(direction);
        };
        controller.Controller.MiniROV_backward.performed += ctx => {
            pressed2 = true;
            controllerValue.miniROV_direction = ChangeMiniROVDirection("b");
        };
        controller.Controller.MiniROV_backward.canceled += ctx => {
            pressed2 = false;
            controllerValue.miniROV_direction = ChangeMiniROVDirection(direction);
        };
        controller.Controller.MiniROV_left.performed += ctx =>{
            pressed3 = true;
            controllerValue.miniROV_direction = ChangeMiniROVDirection("l");
        };
        controller.Controller.MiniROV_left.canceled += ctx => {
            pressed3 = false;
            controllerValue.miniROV_direction = ChangeMiniROVDirection(direction);
        };
        controller.Controller.MiniROV_right.performed += ctx => {
            pressed4 = true;
            controllerValue.miniROV_direction = ChangeMiniROVDirection("r");
        };
        controller.Controller.MiniROV_right.canceled += ctx => {
            pressed4 = false;
            controllerValue.miniROV_direction = ChangeMiniROVDirection(direction);
        };



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
    private static bool pressed1 = false;
    private static bool pressed2 = false;
    private static bool pressed3 = false;
    private static bool pressed4 = false;
    private static string direction = "s";
    private string ChangeMiniROVDirection(string input){
        if(pressed1 == false && pressed2 == false && pressed3 == false && pressed4 == false){
            return "s";
        }else{
            direction = input;
            return direction;
        }
    }

    private int ChangePitchCamera(int angle,int action){
        return angle+action;
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
    bool button3Aux = false;
    private bool[] connectionState = new bool[]{true,false};
    private int selectorconnectionState=-1;
    private bool ChangeConnectPixhawk(bool state){
        if(state == true && button3Aux == false){
            if(selectorconnectionState >= 1){
                selectorconnectionState=-1;
            }
            selectorconnectionState++;
            button3Aux = true;
        }
        else if (state == false){
            button3Aux = false;
        }
        return connectionState[selectorconnectionState];    
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
        //string json = JsonUtility.ToJson(controllerValue);
        //Debug.Log(json);
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
    public bool connect_pixhawk = false;
    public int pitch_camera = 90;

    public string miniROV_direction;


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
