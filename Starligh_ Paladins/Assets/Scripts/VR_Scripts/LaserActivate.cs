using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LaserActivate : MonoBehaviour
{
    //PUBLIC
    public ActionBasedController controller;
    public GameObject gun;
    public Wrist_Instructions wristInstructions;

    private bool _toggle = false;
    private Transform _baseController;
    private int _counter = 0;
    //PRIVATE

    // Start is called before the first frame update
    void Start()
    {
        _baseController = controller.modelPrefab;
        _counter = 0;
    }
    void Update()
    { 
        SetGun();
    }

    public void SwitchToggle(GameObject toggleObject)
    {
        _toggle = !_toggle;
        _counter++;
        if (_counter < 2) {
            wristInstructions.StepIncrement();
        }
        toggleObject.SetActive(_toggle);

    }

    public void SetGun()
    {
        if (_toggle)
        {
            //gun.gameObject.SetActive(true);
            controller.modelPrefab = gun.gameObject.transform;
        }
        else if(!_toggle)
        {
            controller.modelPrefab = _baseController;
            //gun.gameObject.SetActive(false);
        }
    }
}
