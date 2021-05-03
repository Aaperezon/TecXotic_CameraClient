using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraManager : MonoBehaviour
{
    private static CameraManager cameraManager;
    private Transform[] cameras = new Transform[4];

    public static CameraManager GetInstance(){
        return cameraManager;
    }

    public string[] ports = {"","","",""};
    int frameX = (int)(3 * 640);
    int frameY = (int)(3 * 360);
    int width_screen = 3840/4;
    int height_screen = 0;
    int ocultarCamara;
    int mostrarCamara;
    (int, int) perspective1 = (1,3);
    (int, int) perspective2 = (2,3);
    (int, int) perspective3 = (0,3);
    (int, int) perspective4 = (0,2);

    // Start is called before the first frame updates
    void OnEnable()
    {
        for(int i=0;i<this.gameObject.transform.childCount;i++){
            cameras[i] = this.gameObject.transform.GetChild(i);
            mostrarCamara = -1;
            ocultarCamara = 2;
            cameras[i].localPosition = new Vector3(-width_screen, height_screen, ocultarCamara);
            cameras[i].localScale = new Vector3(frameX,frameY, 1);
        }
        if(cameraManager != null){
            GameObject.Destroy(cameraManager);
        }
        else{
            cameraManager = this;
        }
        cameras[1].localPosition = new Vector3(-width_screen,height_screen, mostrarCamara);
        cameras[3].localPosition = new Vector3(width_screen,height_screen, mostrarCamara);
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            ChangePerspective(perspective1);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            ChangePerspective(perspective2);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3)){
            ChangePerspective(perspective3);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4)){
            ChangePerspective(perspective4);
        }
    }

    private void ChangePerspective( (int a ,int b)perspective){
        for(int i = 0;i<this.gameObject.transform.childCount;i++){
            if(i == perspective.a ){
                cameras[i].localPosition = new Vector3(-width_screen,height_screen, mostrarCamara);
            }
            else if (i == perspective.b){
                cameras[i].localPosition = new Vector3(width_screen,height_screen, mostrarCamara);
            }
            else{
                cameras[i].localPosition = new Vector3(width_screen,height_screen, ocultarCamara);
            }
        }
    }

    public string[] GetPorts(){
        return ports;
    }
}
