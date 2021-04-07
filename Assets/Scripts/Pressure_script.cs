using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pressure_script : MonoBehaviour
{
    TMP_Text pressureText;
    // Start is called before the first frame update
    void Start()
    {
        pressureText = gameObject.transform.Find("Indicator").GetComponent<TMP_Text>();
    }
    public void Set(float value){
        pressureText.text = value.ToString();
    }


}
