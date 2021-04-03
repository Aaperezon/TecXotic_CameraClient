using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraManager : MonoBehaviour
{
    public string[] ports = {"5900","5901","5902","5903"};
    private string selection;
    // Start is called before the first frame update
    void Awake()
    {
        selection = ports[0];
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            selection = ports[0];
            Debug.Log("Camera 1");
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            selection = ports[1];
            Debug.Log("Camera 2");
        }
        else if(Input.GetKeyDown(KeyCode.E)){
            selection = ports[2];
            Debug.Log("Camera 3");
        }
        else if(Input.GetKeyDown(KeyCode.R)){
            selection = ports[3];
            Debug.Log("Camera 4");
        }
        
    }

    public string GetSelection(){
        return selection;
    }
}
