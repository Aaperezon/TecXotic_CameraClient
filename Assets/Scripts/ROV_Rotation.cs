using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROV_Rotation : MonoBehaviour
{
    Transform axis;
    
    // Start is called before the first frame update
    void Start()
    {
        axis = GetComponent<Transform>();
    }

    public void RotateROV(float pitch = 0, float yaw = 0, float roll = 0)
    {
        float K = 50 / 3; // Constante de proporcion, angulo maximo  = 30

        float nPitch = (pitch / K);
        float nYaw = (yaw / K);
        float nRoll = (roll / K);

        axis.localRotation = Quaternion.Euler(nPitch, nYaw, -nRoll);
    }

    
}
