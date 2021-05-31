using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    CameraManager cameraManagerComponent;
    private bool active = true;
    private static List<GameObject> settingPanels = new List<GameObject>();
    public GameObject myPanel;

    void Start()
    {
        for(int i = 0; i<this.transform.childCount;i++){
            GameObject tempSettingPanels = this.transform.GetChild(i).gameObject;
            settingPanels.Add(tempSettingPanels);
        }
    }

    public void toggle()
    {   
       
        for(int i=0;i<settingPanels.Count;i++){
            settingPanels[i].SetActive(active);
        }
        active = !active;
    }
}
