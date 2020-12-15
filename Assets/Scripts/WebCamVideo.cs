using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WebCamVideo : MonoBehaviour
{
    private WebCamTexture mainCamera;
    private RawImage rawImage;
    public int indexCam = 0;
    void Awake(){
        rawImage = GameObject.Find("WebCam").GetComponent<RawImage>();
    }
    void Start()
    {
        WebCamDevice device = WebCamTexture.devices[indexCam];
        WebCamTexture webcamTexture = new WebCamTexture(device.name);
        rawImage.texture = webcamTexture;
        rawImage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
        
    }
}
