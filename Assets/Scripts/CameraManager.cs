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
    int ocultarCamara;
    int mostrarCamara;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<this.gameObject.transform.childCount;i++){
            cameras[i] = this.gameObject.transform.GetChild(i);
            mostrarCamara = (int)cameras[0].localPosition.z-2;
            ocultarCamara = (int)cameras[0].localPosition.z+1;
            cameras[i].localPosition = new Vector3(cameras[0].localPosition.x,cameras[0].localPosition.y, ocultarCamara);
            cameras[i].localScale = new Vector3(frameX,frameY, 1);
        }
        if(cameraManager != null){
            GameObject.Destroy(cameraManager);
        }
        else{
            cameraManager = this;
        }
        cameras[0].localPosition = new Vector3(cameras[0].localPosition.x,cameras[0].localPosition.y, mostrarCamara);

       
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            for(int i = 0; i < this.gameObject.transform.childCount; i++){
                if(i == 0){
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, mostrarCamara);
                }else{
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, ocultarCamara);
                }
            }
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            for(int i = 0; i < this.gameObject.transform.childCount; i++){
                if(i == 1){
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, mostrarCamara);
                }else{
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, ocultarCamara);
                }
            }
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3)){
           for(int i = 0; i < this.gameObject.transform.childCount; i++){
                if(i == 2){
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, mostrarCamara);
                }else{
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, ocultarCamara);
                }
            }
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4)){
          for(int i = 0; i < this.gameObject.transform.childCount; i++){
                if(i == 3){
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, mostrarCamara);
                }else{
                    cameras[i].localPosition = new Vector3(cameras[i].localPosition.x,cameras[i].localPosition.y, ocultarCamara);
                }
            }
        }
        
    }

    public string[] GetPorts(){
        return ports;
    }
}
