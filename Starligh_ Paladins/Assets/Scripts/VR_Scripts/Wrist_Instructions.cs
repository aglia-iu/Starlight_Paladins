using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wrist_Instructions : MonoBehaviour
{
    [SerializeField] private int _stepNo = 1;
    [SerializeField] private TMP_Text _wristPanel;

    // Update is called once per frame
    void Start()
    {
        _stepNo = 1;
    }
    void Update()
    {
        WristPanelIncrement();
    }

    public void StepIncrement()
    {
        _stepNo++;
    }

    public void StepIncrementNext()
    {
        if(_stepNo== 1)
        {
            _stepNo++;
        }
       
    }

    public void StepDecrement()
    {
        _stepNo--;
    }

    private void WristPanelIncrement()
    {
        switch (_stepNo)
        {
            default:
                break;
            case 0:
                break;

            case 1:
                _wristPanel.text = "Press the next button on the black screen in front of you.";
                break;

            case 2:
                _wristPanel.text = "TASK 1: Find the levitating gun, then deactivate the tablet";
                break;

            case 3:
                _wristPanel.text = "TASK 2: Deactivate the levitating gun, and activate the oxygen cylinder.";
                break;

            case 4:
                _wristPanel.text = "TASK 2: Deactivate the oxygen cylinder, and press the next button on the black screen in front of you. ";
                break;

            case 5:
                _wristPanel.text = "TASK 3: Navigate to each alien, then, use the oxygen tank to collect and store the aliens.";
                break;

            case 6:
                _wristPanel.text = "TASK 4: Travel to the glowing teleportation pad to begin reassembling the ship";
                break;

            case 7:
                _wristPanel.text = "TASK 6: Program the ship to move forward. ";
                break;

            case 8:
                _wristPanel.text = "Deposit Aliens into the cockpit of the ship";
                break;

            case 9:
                _wristPanel.text = "MISSION ACCOMPLISHED!";
                break;
        }
    }
}
