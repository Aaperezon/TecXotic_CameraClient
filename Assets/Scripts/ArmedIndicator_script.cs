using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArmedIndicator_script : MonoBehaviour
{
    TMP_Text textArmed;
    void Start()
    {
        textArmed = gameObject.transform.Find("Indicator").GetComponent<TMP_Text>();
    }
    public void Set(bool armed)
    {
        if(armed == true)
        {
            textArmed.text = "ARMED";
        }
        else
        {
            textArmed.text = "DISARMED";
        }
    }
}
