using System;
using System.Net.Sockets;
using UnityEngine;
public class ReceiveData : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if(NetworkManager.Instance.GetConnectionStatus() == true){
            GetReading();
        }
        
    }

    void GetReading(){
      
        
    }
    
}


