using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class ConnectionSettings : MonoBehaviour
{
    private static string fileName = "/Source/ConnectionSettings.json";
    private Text[] placeholder = new Text[2];
    private Text[] input_value = new Text[2];
    void OnEnable(){
        ConnectionConstants pidConstants = Load();
        for(int i = 0; i<this.transform.childCount-1;i++){
            if(this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).gameObject.name == "InputField Input Caret"){
                placeholder[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
            }
            else{
                placeholder[i] = this.transform.GetChild(i).transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
            }
        }
        placeholder[0].text = pidConstants.IP.ToString();
        placeholder[1].text = pidConstants.PORT.ToString();
       
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
        ConnectionConstants saveConnection = new ConnectionConstants();
        
        if(input_value[0].text == "" ){
            saveConnection.IP = placeholder[0].text;
        }
        else{
            saveConnection.IP = input_value[0].text;
        }
        if(input_value[1].text == ""){
            saveConnection.PORT = int.Parse(placeholder[1].text);
        }
        else{
            saveConnection.PORT = int.Parse(input_value[1].text);
        }
       
        string jsonConnection = JsonUtility.ToJson(saveConnection);
        File.WriteAllText(Application.dataPath + fileName, jsonConnection);
        Debug.Log("Guardado: "+Application.dataPath + fileName);
        this.GetComponentInParent<Settings>().toggle();

    }
    public static ConnectionConstants Load(){
        if(File.Exists(Application.dataPath+fileName)){
            string saveString = File.ReadAllText(Application.dataPath+fileName);
            ConnectionConstants jsonConnection = JsonUtility.FromJson<ConnectionConstants>(saveString);
            return jsonConnection;
        }
        else{
            ConnectionConstants auxConnection = new ConnectionConstants();
            return auxConnection;
        }
    }

   
}
 public class ConnectionConstants{
        public  string IP = "";
        public  int PORT = 0;
}
