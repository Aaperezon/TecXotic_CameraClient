using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveColor : MonoBehaviour
{

    private bool Active = false;

    public void ActivateAgent()
    {
        Active = !Active;

        if (Active)
        {
            GetComponent<Image>().color = new Color32(160, 240, 100, 255);
        }
        else
        {
            GetComponent<Image>().color = new Color32(190, 190, 190, 255);
        }
    }
}
