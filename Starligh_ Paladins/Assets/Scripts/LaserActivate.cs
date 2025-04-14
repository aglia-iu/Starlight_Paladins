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
    //PRIVATE

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGun()
    {
        gun.gameObject.SetActive(true);
        controller.modelPrefab = gun.gameObject.transform;
    }
}
