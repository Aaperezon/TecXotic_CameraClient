using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class PIDSettings : MonoBehaviour
{
    private string fileName = "/Source/PIDConstants.json";

    private Text[] placeholder = new Text[3];
    private Text[] input_value = new Text[3];

    void OnEnable(){
        PIDConstants pidConstants = Load();
        for(int i = 0; i<this.transform.childCount-1;i++){
            if(this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).gameObject.name == "InputField Input Caret"){
                placeholder[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
            }
            else{
                placeholder[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
            }
        }
        placeholder[0].text = pidConstants.Pk.ToString();
        placeholder[1].text = pidConstants.Ik.ToString();
        placeholder[2].text = pidConstants.Dk.ToString();
       
    }

   

    public void Save(){
        for(int i = 0; i<this.transform.childCount-1;i++){
            if(this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).gameObject.name == "InputField Input Caret"){
                input_value[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(2).GetComponent<Text>();
            }
            else{
                input_value[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
            }
        }
        PIDConstants savePID = new PIDConstants();
        
        if(input_value[0].text == "" ){
            savePID.Pk = float.Parse(placeholder[0].text);
        }
        else{
            savePID.Pk = float.Parse(input_value[0].text);
        }
        if(input_value[1].text == ""){
            savePID.Ik = float.Parse(placeholder[1].text);
        }
        else{
            savePID.Ik = float.Parse(input_value[1].text);
        }
        if(input_value[2].text == "" ){
            savePID.Dk = float.Parse(placeholder[2].text);
        }
        else{
            savePID.Dk = float.Parse(input_value[2].text);
        }
       
        string jsonPID = JsonUtility.ToJson(savePID);
        File.WriteAllText(Application.dataPath + fileName, jsonPID);
        Debug.Log("Guardado: "+Application.dataPath + fileName);
        this.GetComponentInParent<Settings>().toggle();

    }



    private PIDConstants Load(){
        if(File.Exists(Application.dataPath+fileName)){
            string saveString = File.ReadAllText(Application.dataPath+fileName);
            PIDConstants jsonPID = JsonUtility.FromJson<PIDConstants>(saveString);
            return jsonPID;
        }
        else{
            PIDConstants auxPID = new PIDConstants();
            return auxPID;
        }
    }



public class PIDConstants{
        public  float Pk = 0;
        public  float Ik = 0;
        public  float Dk = 0;
}

}

