using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisionCamera : MonoBehaviour
{
    GameObject triangle;
    GameObject camera;
    GameObject lineUp;
    GameObject lineDown;
    private float currentValue;
    private float speed;
    private bool loading;

    // Start is called before the first frame update
    void Start()
    {
        camera = this.transform.GetChild(3).gameObject;
        triangle = this.transform.GetChild(1).gameObject;
        lineUp = this.transform.GetChild(0).gameObject;
        lineDown = this.transform.GetChild(4).gameObject;

        triangle.SetActive(false);
        camera.GetComponent<Image>().fillAmount = 0.0f;
        currentValue = 0.0f;
        speed = 130;
        loading = false;
        
    }

    void Update()
    {
        if (loading)
        {
            if (currentValue < 100)
            {
                currentValue += speed * Time.deltaTime;
            }
            else
            {
                triangle.SetActive(true);
            }

            camera.GetComponent<Image>().fillAmount = currentValue / 100;
                
        }
    }

    public void Set(float z, bool active)
    {
        if (active)
        {
            loading = true;
            //triangle.transform.Rotation(0, 0, z);
        }
    }
}
