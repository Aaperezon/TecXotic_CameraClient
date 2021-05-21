using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class CameraPanel : MonoBehaviour
{
    GameObject[] cameraStream = new GameObject[4];
    private Text[] placeholder = new Text[5];
    private Text[] input_value = new Text[5];
    private static CameraPorts cameraSettings;

    private static string fileName = "/Source/cameraSettings.json";


    public void OnEnable()
    {   
        cameraSettings = Load();
        for(int i = 0; i<this.transform.childCount-1;i++){
            if(this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).gameObject.name == "InputField Input Caret"){
                placeholder[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
            }
            else{
                placeholder[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
            }
        }
        placeholder[0].text = cameraSettings.camera1.ToString();
        placeholder[1].text = cameraSettings.camera2.ToString();
        placeholder[2].text = cameraSettings.camera3.ToString();
        placeholder[3].text = cameraSettings.camera4.ToString();
        placeholder[4].text = cameraSettings.idMiniROV.ToString();

    }
    IEnumerator RestartStreaming()
    {
        int cameraCount = GameObject.FindGameObjectWithTag("CameraManager").transform.childCount;
        for (int i = 0 ; i < cameraCount; i++){
            cameraStream[i] = GameObject.FindGameObjectWithTag("CameraManager").transform.GetChild(i).gameObject;
            cameraStream[i].SetActive(false);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0 ; i < cameraCount; i++){
            cameraStream[i].SetActive(true);
        }
        this.GetComponentInParent<Settings>().toggle();

    }
   


    public void Save(){
        for(int i = 0; i<this.transform.childCount-1; i++){
            if(this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).gameObject.name == "InputField Input Caret"){
                input_value[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(2).GetComponent<Text>();
            }
            else{
                input_value[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
            }
        }

        if(input_value[0].text == "" ){
            cameraSettings.camera1 = int.Parse(placeholder[0].text);
        }
        else{
            cameraSettings.camera1 = int.Parse(input_value[0].text);
        }
        if(input_value[1].text == ""){
            cameraSettings.camera2 = int.Parse(placeholder[1].text);
        }
        else{
            cameraSettings.camera2 = int.Parse(input_value[1].text);
        }
        if(input_value[2].text == ""){
            cameraSettings.camera3 = int.Parse(placeholder[2].text);
        }
        else{
            cameraSettings.camera3 = int.Parse(input_value[2].text);
        }
        if(input_value[3].text == ""){
            cameraSettings.camera4 = int.Parse(placeholder[3].text);
        }
        else{
            cameraSettings.camera4 = int.Parse(input_value[3].text);
        }
        if(input_value[4].text == ""){
            cameraSettings.idMiniROV = int.Parse(placeholder[4].text);
        }
        else{
            cameraSettings.idMiniROV = int.Parse(input_value[4].text);
        }

        string jsonPID = JsonUtility.ToJson(cameraSettings);
        File.WriteAllText(Application.dataPath + fileName, jsonPID);
        Debug.Log("Guardado: "+Application.dataPath + fileName);
        StartCoroutine(RestartStreaming());
    }



    public static CameraPorts Load(){
        if(File.Exists(Application.dataPath+fileName)){
            string saveString = File.ReadAllText(Application.dataPath+fileName);
            CameraPorts jsonPID = JsonUtility.FromJson<CameraPorts>(saveString);
            return jsonPID;
        }
        else{
            CameraPorts auxPID = new CameraPorts();
            return auxPID;
        }
    }
     
   
}
[Serializable]
 public class CameraPorts{
        public int camera1 = 5600;
        public int camera2 = 5601;
        public int camera3 = 5602;
        public int camera4 = 5603;
        public int idMiniROV = 3;
}
