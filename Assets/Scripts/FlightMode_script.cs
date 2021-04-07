using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlightMode_script : MonoBehaviour
{
    TMP_Text textMode;
    void Start()
    {
        textMode = GameObject.Find("Indicator").GetComponent<TMP_Text>();
    }
    public void ModeFunction(string mode)
    {
        if (mode == "NORMAL")
        {
            textMode.text = "NORMAL";
        }
        if (mode == "STABILIZE")
        {
            textMode.text = "STABILIZE";
        }
        if (mode == "DEPTH HOLD")
        {
            textMode.text = "DEPTH HOLD";
        }
    }
}
