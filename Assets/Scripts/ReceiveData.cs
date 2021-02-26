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
            SetTarget(NetworkManager.GetReceived().target_x,  NetworkManager.GetReceived().target_y, NetworkManager.GetReceived().target_width,  NetworkManager.GetReceived().target_height);
        }
    }

    void SetTarget(int target_x, int target_y, int target_width, int target_height){

        //target_x = target_x-(target_width/2);
        //target_y = target_y-(target_height/2);
        target_x = (int)(2.33*target_x-350);
        target_y = (int)(1.46*target_y-150)*-1;
        target_width = target_width * 2;
        target_height = target_height * 2;
        target.localPosition = new Vector3( target_x,  target_y, 0);
        target.localScale = new Vector3( target_width,  target_height, 1);
    }

    
}


