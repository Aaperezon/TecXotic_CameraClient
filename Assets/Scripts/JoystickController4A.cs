using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickController4A : MonoBehaviour
{
    GameObject center;
    GameObject up;
    GameObject down;
    GameObject right;
    GameObject left;
    private float currentValue;
    private float speed;
    private bool loading;

    // Start is called before the first frame update
    void Start()
    {
        left = this.transform.GetChild(0).gameObject;
        right = this.transform.GetChild(1).gameObject;
        down = this.transform.GetChild(2).gameObject;
        up = this.transform.GetChild(3).gameObject;
        center = this.transform.GetChild(4).gameObject;

        left.GetComponent<Image>().fillAmount = 0.0f;
        down.GetComponent<Image>().fillAmount = 0.0f;
        right.GetComponent<Image>().fillAmount = 0.0f;
        up.GetComponent<Image>().fillAmount = 0.0f;
        center.GetComponent<Image>().fillAmount = 0.0f;

        currentValue = 0.0f;
        speed = 85;
        loading = false;
    }

    void Update()
    {
        if(loading)
        {
            if (currentValue < 100)
            {
                currentValue += speed * Time.deltaTime;
            }
            center.GetComponent<Image>().fillAmount = currentValue / 100;
        }
    }

    public void Set(float x, float y, bool active)
    {
        if (active)
        {
            loading = true;
            
            if (x < 0)
            {
                left.GetComponent<Image>().fillAmount = -x;
            }
            else
            {
                right.GetComponent<Image>().fillAmount = x;
            }

            if (y < 0)
            {
                down.GetComponent<Image>().fillAmount = -y;
            }
            else
            {
                up.GetComponent<Image>().fillAmount = y;
            }
        }
    }          
}
