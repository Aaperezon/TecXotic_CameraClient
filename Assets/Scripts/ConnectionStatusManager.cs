using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
public class ConnectionStatusManager : MonoBehaviour
{
    public GameObject toggleSwitch;
  
    // Start is called before the first frame update
    public void Start()
    {

    }
    

    // Update is called once per frame
    public void Update()
    {
        if(toggleSwitch.GetComponent<ToggleController>().GetState() == true){
            this.GetComponent<NetworkManager>().enabled = true;
        }else{
            this.GetComponent<NetworkManager>().enabled = false;
        }
       
    }
   
   


   

  
}

