using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMenu_ToggleUI : MonoBehaviour
{
    //PUBLIC VARIABLES
    //public GameObject toggleObject;
    public Material materialEmissive;
    public Material materialMatte;
    public bool activateGun = false;
    public Wrist_Instructions wristInstructions;

    // PRIVATE VARIABLES
    private bool _toggle = false;
    private int _counter = 0;

    void Start()
    {
        _counter = 0;
    }
    public void SwitchToggle(GameObject toggleObject)
    {
        _toggle = !_toggle;
        _counter++;
        if(_counter < 3 && toggleObject.tag == "jar")
        {
            wristInstructions.StepIncrement();
        }
        toggleObject.SetActive(_toggle);

    }

    public void SwitchMaterial()
    {
        _toggle = !_toggle;
        if (_toggle)
        {
            this.GetComponent<Renderer>().material = materialEmissive;
        }
        else
        {
            this.GetComponent<Renderer>().material = materialMatte;

        }
    }
}
