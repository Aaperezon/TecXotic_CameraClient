using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraToggle_Script : MonoBehaviour
{
    public GameObject myPanel;
    private bool active = true;
    CameraManager cameraManagerComponent;
    public Text[] textPlaceholder = new Text[4];
    public Text[] inputText = new Text[4];
    GameObject[] cameraStream = new GameObject[4];


    public void Start()
    {
        cameraManagerComponent = GameObject.Find("CameraManager").GetComponent<CameraManager>();

    }
    public void Toggle()
    {   
        Debug.Log("panel: "+active);
        if(active == true){
            for(int i=0;i<this.gameObject.transform.GetChild(0).childCount-1;i++){
                //Debug.Log(this.gameObject.transform.GetChild(0).GetChild(i).GetChild(0).Find("Placeholder").name);
                textPlaceholder[i] = this.gameObject.transform.GetChild(0).GetChild(i).GetChild(0).Find("Placeholder").GetComponent<Text>();
                inputText[i] =       this.gameObject.transform.GetChild(0).GetChild(i).GetChild(0).Find("Text").GetComponent<Text>();
                inputText[i].text = " ";
                textPlaceholder[i].text = cameraManagerComponent.ports[i];
            }

        }
        myPanel.SetActive(active);
        active = !active;
    }

    public void ReconnectCamera()
    {
        for(int i = 0; i<inputText.Length;i++){
            if(inputText[i].text == ""){
                cameraManagerComponent.ports[i]  = textPlaceholder[i].text;
            }else{
                cameraManagerComponent.ports[i] = inputText[i].text;
            }
        }
        StartCoroutine(RestartStreaming());
        Toggle();

    }

    IEnumerator RestartStreaming()
    {
        for (int i = 0 ; i < GameObject.FindGameObjectWithTag("CameraManager").transform.childCount; i++){
            cameraStream[i] = GameObject.FindGameObjectWithTag("CameraManager").transform.GetChild(i).gameObject;
            cameraStream[i].SetActive(false);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0 ; i < GameObject.FindGameObjectWithTag("CameraManager").transform.childCount; i++){
            cameraStream[i].SetActive(true);
        }

    }
}
