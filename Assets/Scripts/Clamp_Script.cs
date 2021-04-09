using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clamp_Script : MonoBehaviour
{
    public GameObject clampObject;
    TMP_Text clampText;



    // Start is called before the first frame update
    void Start()
    {
        clampText = gameObject.transform.Find("Indicator").GetComponent<TMP_Text>();
    }
    public void Set(bool clamp)
    {
        if (clamp == true)
        {
            clampText.text = "Open";
            clampObject.GetComponent<Image>().color = new Color32(180, 255, 0, 250);
        }
        else
        {
            clampText.text = "Close";
            clampObject.GetComponent<Image>().color = new Color32(164, 38, 38, 250);
        }
    }
}
