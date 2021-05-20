using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleIndicator : MonoBehaviour
{
    private bool Active = true;
    // Start is called before the first frame update
    public void Toggle()
    {
        this.gameObject.SetActive(Active);
        Active = !Active;
    }
}
