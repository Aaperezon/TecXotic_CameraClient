using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{


    RemoteController controller;
    Vector2 rotate;
    
    void Awake()
    {

        controller = new RemoteController();

        controller.Controller.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controller.Controller.Rotate.canceled += ctx => rotate = Vector2.zero;
    }

    void Update()
    {
        Vector2 r = new Vector2(rotate.y, rotate.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }
}
