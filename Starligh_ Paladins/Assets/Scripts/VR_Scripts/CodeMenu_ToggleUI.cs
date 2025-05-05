using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMenu_ToggleUI : MonoBehaviour
{
    //PUBLIC VARIABLES
    //public GameObject toggleObject;
    public Material materialEmissive;
    public Material materialMatte;

    // PRIVATE VARIABLES
    private bool toggle = false;
    

    public void SwitchToggle(GameObject toggleObject)
    {
        toggle = !toggle;
        toggleObject.SetActive(toggle);

    }

    public void SwitchMaterial()
    {
        toggle = !toggle;
        if (toggle)
        {
            this.GetComponent<Renderer>().material = materialEmissive;
        }
        else
        {
            this.GetComponent<Renderer>().material = materialMatte;

        }
    }
}
