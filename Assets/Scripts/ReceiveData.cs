using System;
using System.IO;
using UnityEngine;
using UnityEditor;
public class ReceiveData : MonoBehaviour
{
    private Transform target;
    void Start()
    {
        target=GameObject.Find("Target").GetComponent<Transform>();
    }

    void Update()
    {   
        if(NetworkManager.GetReceived()!=null && target != null){
            //Debug.Log("server message received as: "+NetworkManager.GetReceived().target_x); 
            target.localPosition = new Vector3( NetworkManager.GetReceived().target_x,  NetworkManager.GetReceived().target_y, -1);
            target.localScale = new Vector3( NetworkManager.GetReceived().target_width,  NetworkManager.GetReceived().target_height, 1);
        }
    }

    
}


