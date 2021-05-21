using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agent3 : MonoBehaviour
{
    AgentsIndicator agent;
    RemoteController controller;
    ControllerValue controllerValue;

    Image grid;
    void Start()
    {
        grid = this.gameObject.transform.Find("Grid").GetComponent<Image>();
        agent = this.GetComponent<AgentsIndicator>();
        controller = SendData.GetController();
        controllerValue = SendData.GetSender();

        controller.Controller.Agent3_x.performed += ctx =>{
            int value = (int)(ctx.ReadValue<float>()*10);
            controllerValue.agent3_x = value;
            int axis = (int)grid.transform.localPosition.x;
            grid.transform.localPosition = new Vector3(axis+=value, grid.transform.localPosition.y,grid.transform.localPosition.z);

        };
        controller.Controller.Agent3_x.canceled += ctx => {
            controllerValue.agent3_x = 0;
            grid.transform.localPosition = new Vector3(grid.transform.localPosition.x, grid.transform.localPosition.y,grid.transform.localPosition.z);

        };

        controller.Controller.Agent3_y.performed += ctx => {
            int value = (int)(ctx.ReadValue<float>()*10);
            controllerValue.agent3_y = value;
            int axis = (int)grid.transform.localPosition.y;
            grid.transform.localPosition = new Vector3(grid.transform.localPosition.x, axis+=value, grid.transform.localPosition.z);
        };
        controller.Controller.Agent3_y.canceled += ctx => {
            controllerValue.agent3_y = 0;
            grid.transform.localPosition = new Vector3(grid.transform.localPosition.x, grid.transform.localPosition.y,grid.transform.localPosition.z);

        };
        
        controller.Controller.Agent3_resize.performed += ctx => {
            (float,float) values = ChangeSize(true);
            controllerValue.agent3_w = values.Item1;
            controllerValue.agent3_h =  values.Item2;
            grid.transform.localScale = new Vector3(values.Item1, values.Item2,1 );
        };
        controller.Controller.Agent3_resize.canceled += ctx => {
            (float,float) values = ChangeSize(false);
            controllerValue.agent3_w = values.Item1;
            controllerValue.agent3_h =  values.Item2;
            grid.transform.localScale = new Vector3(values.Item1, values.Item2,1 );
        };

        controller.Controller.Agent3_shoot.performed += ctx => controllerValue.agent3_shoot = true;
        controller.Controller.Agent3_shoot.canceled += ctx => controllerValue.agent3_shoot = false;
    }
    bool button2Aux = false;
    private (float,float)[] sizeModes = new (float,float)[]{(6,2.5f),(2.5f,2.5f)};
    private int selectorarmSize=-1;
     private (float,float) ChangeSize(bool state){
        if(state == true && button2Aux == false){
            if(selectorarmSize >= 1){
                selectorarmSize=-1;
            }
            selectorarmSize++;
            button2Aux = true;
        }
        else if (state == false){
            button2Aux = false;
        }


        return sizeModes[selectorarmSize];    
    }

    void Update()
    {
        bool move = this.gameObject.GetComponent<AgentsIndicator>().GetStatus();
        if(move == true){
            grid.transform.gameObject.SetActive(true);
        }else{
            grid.transform.gameObject.SetActive(false);
        }
       
        
    }
}
