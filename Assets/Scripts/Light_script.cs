using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light_script : MonoBehaviour
{
    public GameObject lightParticle;

    void Start(){
        lightParticle = gameObject.transform.Find("Pressure").GetComponent<TMP_Text>();

    }
    
    void changeColor(bool state)
    {
        if (lightOn)
        {
            lightParticle.GetComponent<Image>().color = new Color32(180, 255, 0, 255);
        } else
        {
            lightParticle.GetComponent<Image>().color = new Color32(255, 0, 10, 0);
        }
    }
    
}
