using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using static UnityEngine.Rendering.DebugUI;

public class LibraryBlock_Behavior : MonoBehaviour
{
    public Canvas parentCanvas;
    //[SerializeField] Panel parentPanel;
    public GameObject buttonType;
    //private bool _isSelected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isInstantiated()
    {
        //if (_isSelected) 
        //{
           // _isSelected = !_isSelected;
           Debug.Log("Is Instantiated");
            GameObject newButton = Instantiate(buttonType, parentCanvas.transform.position,parentCanvas.transform.rotation);
            newButton.transform.SetParent(parentCanvas.transform,true);
            newButton.transform.localScale = buttonType.transform.localScale;
            
        //}
    }
}
