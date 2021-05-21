using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgentsIndicator : MonoBehaviour
{
    private bool status = false;

    public void Set(bool indicatorStatus)
    {
        status = indicatorStatus;
        if (indicatorStatus)
        {
            GetComponent<Image>().color = new Color32(160, 240, 100, 255);
        }
        else
        {
            GetComponent<Image>().color = new Color32(190, 190, 190, 255);
        }
        indicatorStatus = !indicatorStatus;
    }

    public bool GetStatus(){
        return status;
    }
   

}
