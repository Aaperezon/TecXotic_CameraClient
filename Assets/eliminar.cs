using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eliminar : MonoBehaviour
{

    TMP_Text textMeshPro;
    Transform ejes;

    // Start is called before the first frame update
    void Start()
    {
        //textMeshPro = gameObject.transform.Find("Armed").GetComponent<TMP_Text>();
        textMeshPro = GameObject.FindGameObjectWithTag("ArmedFlag").GetComponent<TMP_Text>();
        ejes = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ejes.localRotation = Quaternion.Euler(10f,20f,30f); 


        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Clic Izquierdo");
            StartCoroutine(Armado());


        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("Clic Derecho");
            StopAllCoroutines();
        }

        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("Boton A");

        }

        Armed_Disarmed(true);

    }
    IEnumerator Armado(){
        Armed_Disarmed(true);
        yield return new WaitForSeconds(2);
        Armed_Disarmed(false);
    }

    void Armed_Disarmed(bool armed){
        if(armed == true){
            textMeshPro.text = "Armed";
        }else{
            textMeshPro.text = "Disarmed";
        }
    }

}
