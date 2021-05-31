using System;
using System.IO;
using UnityEngine;
using UnityEditor;
public class ReceiveData : MonoBehaviour
{
   
    GameObject pressureIndicator1;
    GameObject clampIndicator;
    GameObject lightIndicator;
    GameObject pressureIndicator2;
    GameObject pixhawkConection;
    ReceivedValue received;

    void Start()
    {
       
        pressureIndicator1 = GameObject.Find("PressureIndicator1");
        clampIndicator = GameObject.Find("ClampIndicator");
        lightIndicator = GameObject.Find("LightIndicator");
        pressureIndicator2 = GameObject.Find("PressureIndicator2");
        pixhawkConection = GameObject.Find("PixhawkConection");
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
            pressureIndicator1.SendMessage("Set", received.pressure);
            clampIndicator.SendMessage("Set", received.clamp);
            //lightIndicator.SendMessage("Set", received.light);
            pressureIndicator2.SendMessage("Set", received.pressure);
            pixhawkConection.SendMessage("Set", received.connection_pixhwak);
            
          
        }else{
            pixhawkConection.SendMessage("Set", false);
        }

    }

   

    
}


