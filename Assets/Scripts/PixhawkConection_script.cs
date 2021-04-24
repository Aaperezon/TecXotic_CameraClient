using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PixhawkConection_script : MonoBehaviour
{
    Image sprite;
    public Color onColorBg;
	public Color offColorBg;
    GameObject conection;

    void Start()
    {
        sprite = gameObject.GetComponent<Image>();
        conection = GameObject.Find("ProgressCircle1");
        sprite.color = offColorBg;
        conection.SetActive(true);

    }

    void Update()
    {
       

    }

    public void Set(bool state)
    {
        if(state == true){
            sprite.color = onColorBg;
            conection.SetActive(false);
        }else{
            sprite.color = offColorBg;
            conection.SetActive(true); 
        }
        
    }

}
