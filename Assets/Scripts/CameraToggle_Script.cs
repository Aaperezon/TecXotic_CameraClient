using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraToggle_Script : MonoBehaviour
{
    public GameObject myPanel;
    private bool active = false, act1 = false;
    GameObject camera1;
    GameObject toggle1;
    public void Start()
    {
        camera1 = GameObject.Find("VideoStream1");
        toggle1 = GameObject.Find("Toggle1");

    }
    public void toggle()
    {
        myPanel.SetActive(active);
        active = !active;
    }


    public void ActivateCamera1()
    {
        camera1.GetComponent<Camera_Connect>().enabled = !camera1.GetComponent<Camera_Connect>().enabled;

        if (camera1.GetComponent<Camera_Connect>().enabled)
        {
            toggle1.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            toggle1.GetComponent<Toggle>().isOn = false;
        }
    }
}
