using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UUVIndicator_script : MonoBehaviour
{
    TMP_Text textType;
    void Start()
    {
        textType = GameObject.Find("Indicator").GetComponent<TMP_Text>();
    }
    public void TypeFunction(int mode)
    {
        if (mode == 0)
        {
            textType.text = "MAIN";
        }
        if (mode == 1)
        {
            textType.text = "MINI-SUB";
        }
    }
}
