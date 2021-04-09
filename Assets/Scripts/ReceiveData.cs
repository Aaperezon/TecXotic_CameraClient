using System;
using System.IO;
using UnityEngine;
using UnityEditor;
public class ReceiveData : MonoBehaviour
{
    GameObject armedIndicator;
    GameObject flightMode;
    GameObject pressureIndicator1;
    GameObject clampIndicator;
    GameObject lightIndicator;
    GameObject pressureIndicator2;
    ReceivedValue received;
    void Start()
    {
        armedIndicator = GameObject.Find("ArmedIndicator");
        flightMode = GameObject.Find("FlightMode");
        pressureIndicator1 = GameObject.Find("PressureIndicator1");
        clampIndicator = GameObject.Find("ClampIndicator");
        lightIndicator = GameObject.Find("LightIndicator");
        pressureIndicator2 = GameObject.Find("PressureIndicator2");
    }

    void Update()
    {   
        received = NetworkManager.GetReceived();
        
        if(received != null){
            /*
            Debug.Log("server message received as: "
            +received.arm_disarm+"  "
            +received.flight_mode+"  "
            +received.pressure+"  "
            +received.clamp+"  "
            +received.light+"  "
            +received.throttle+"  "
            +received.roll+"  "
            +received.pitch+"  "
            +received.yaw+"  "
            ); 
            */
            armedIndicator.SendMessage("Set", received.arm_disarm);
            pressureIndicator1.SendMessage("Set", received.pressure);
            clampIndicator.SendMessage("Set", received.clamp);
            //lightIndicator.SendMessage("Set", received.light);
            pressureIndicator2.SendMessage("Set", received.pressure);
            flightMode.SendMessage("Set", received.flight_mode);
          
          
        }
    }

   

    
}


