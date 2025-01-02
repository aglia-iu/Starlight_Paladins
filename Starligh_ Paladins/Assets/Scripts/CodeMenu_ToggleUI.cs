using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMenu_ToggleUI : MonoBehaviour
{
    //PUBLIC VARIABLES
    public GameObject UICanvas;

    // PRIVATE VARIABLES
    private bool toggle = false;

    public void SwitchToggle()
    {
        toggle = !toggle;
        UICanvas.SetActive(toggle);

    }
}
