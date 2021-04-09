using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlightMode_script : MonoBehaviour
{
    TMP_Text textMode;
    void Start()
    {
        textMode = gameObject.transform.Find("Indicator").GetComponent<TMP_Text>();
    }
    public void Set(string mode){
        textMode.text = mode;
    }



}
