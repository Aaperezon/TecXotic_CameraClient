using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PixhawkConnection : MonoBehaviour
{
    GameObject conectionCircle;
    Image connection;

    void Start()
    {
        connection = this.gameObject.GetComponent<Image>();
        conectionCircle = GameObject.Find("ProgressCircle1");
        connection.color = Color.red;
        conectionCircle.SetActive(true);

    }

    void Update()
    {
       

    }

    public void Set(bool state)
    {
        if(state == true){
            conectionCircle.SetActive(false);
            connection.color = Color.green;
        }else{
            connection.color = Color.red;
            conectionCircle.SetActive(true); 
        }
        
    }

}
