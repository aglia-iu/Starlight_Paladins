using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class HighlightControls : MonoBehaviour
{
    //[SerializeField] private GameObject _player;
    private GameObject _leftJoystick, _rightJoystick;
    private GameObject _leftTrigger, _rightTrigger;

    private Color joystickColor;
    //private Vector3 playerPos;

    public GameObject leftController, rightController;
    public List<GameObject> leftControllerChildren;
    public GameObject[] rightControllerChildren;
    // Start is called before the first frame update
    void Start()
    {
        //playerPos = _player.transform.localPosition;
        leftController.GetChildGameObjects(leftControllerChildren);
        if (leftControllerChildren.Count == 0)
        {
            Debug.Log("Got nothing");
        }
        _leftJoystick = leftController.GetNamedChild("ThumbStick");
        _rightJoystick = rightController.GetNamedChild("ThumbStick");

        _rightTrigger = rightController.GetNamedChild("Trigger");

        joystickColor = _leftJoystick.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HighlightLeftJoystick()
    {
        if (_leftJoystick && _rightJoystick)
        {
            //_leftJoystick.GetComponent<MeshRenderer>().material.color = Color.blue;
            _rightJoystick.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else
        {
            Debug.Log("No Joystick!");
        }
    }

    public void DisableHighlightLeftJoystick()
    {
        if (_leftJoystick && _rightJoystick)
        {
            //_leftJoystick.GetComponent<MeshRenderer>().material.color = joystickColor;
            _rightJoystick.GetComponent<MeshRenderer>().material.color = joystickColor;
        }   
        else
        {
            Debug.Log("No Joystick!");
        }
    }
    public void HighlightRightJoystick()
    {
        if (_leftJoystick && _rightJoystick)
        {
            _leftJoystick.GetComponent<MeshRenderer>().material.color = Color.blue;
            //_rightJoystick.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else
        {
            Debug.Log("No Joystick!");
        }
    }

    public void DisableHighlightRightJoystick()
    {
        if (_leftJoystick && _rightJoystick)
        {
            _leftJoystick.GetComponent<MeshRenderer>().material.color = joystickColor;
            //_rightJoystick.GetComponent<MeshRenderer>().material.color = joystickColor;
        }   
        else
        {
            Debug.Log("No Joystick!");
        }
    }

    public void HighlightRightTrigger()
    {
        if (_rightTrigger)
        {
            _rightTrigger.GetComponent<MeshRenderer>().material.color = Color.blue;
            //_rightJoystick.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else
        {
            Debug.Log("No Trigger!");
        }
    }

    public void DisableHighlightRightTrigger()
    {
        if (_rightTrigger)
        {
            _rightTrigger.GetComponent<MeshRenderer>().material.color = joystickColor;
            //_rightJoystick.GetComponent<MeshRenderer>().material.color = joystickColor;
        }
        else
        {
            Debug.Log("No Trigger!");
        }
    }
}


