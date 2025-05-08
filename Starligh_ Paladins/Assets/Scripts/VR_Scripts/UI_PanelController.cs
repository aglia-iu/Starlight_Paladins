using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_PanelController : MonoBehaviour
{
    [SerializeField] private int _stepNo = 1;

    [SerializeField] private TMP_Text _UI_Panel_Text1;
    [SerializeField] private TMP_Text _UI_Panel_Text2;
    [SerializeField] private TMP_Text _UI_Panel_Text3;
    [SerializeField] private TMP_Text _UI_Panel_Text4;
    [SerializeField] private TMP_Text _UI_Panel_Text5;

    [SerializeField] private HighlightControls highlightControls;
    // Start is called before the first frame update
    void Start()
    {
        _stepNo = 1;
    }
    // Update is called once per frame
    void Update()
    {
        UIPanelIncrement();
    }

    public void StepIncrement()
    {
        _stepNo++;
    }

    public void StepDecrement()
    {
        _stepNo--;
    }

    private void UIPanelIncrement()
    {
        switch (_stepNo)
        {
            default:
                break;
            case 0:
                break;

            case 1:
                _UI_Panel_Text1.text = "To keep track of the status of your mission, and any new instructions, press the blue button on your wristwatch to view your inventory, and any further instructions. To move to the next step, press the next button using the Trigger Button (look at the remote in your right hand - press the Next button using the blue key.)";
                highlightControls.HighlightRightTrigger();
                break;

            case 2:
                _UI_Panel_Text1.text = "In your inventory, you have a levitating gun and an oxygen cylinder. Press the button to activate each item. To deactivate the item, press the button again, and it will return to your inventory.";
                highlightControls.DisableHighlightLeftJoystick();
                highlightControls.DisableHighlightRightTrigger();

                break;

            case 3:
                _UI_Panel_Text1.text = "To begin iterating through the environment, look at the remote in your right hand. Do you see a highlighted button? That button is the joystick, and if you push it forward, it will help you teleport to the glowing circle in front of you.";
                highlightControls.HighlightLeftJoystick();
                break;

            case 4:
                _UI_Panel_Text2.text = "The attack is worse than you expected - the aliens are outside the spacecraft with no oxygen. Using the joystick on your left remote (highlighted) navigate the jetpack to each alien. Then, using the Oxygen Tank in your inventory, collect each of the aliens. Time is running out. You must hurry! ";
                highlightControls.DisableHighlightLeftJoystick();
                highlightControls.HighlightRightJoystick();
                highlightControls.DisableHighlightRightTrigger();
                break;

            case 5:
                _UI_Panel_Text3.text = "Now that the aliens are safe, it is time to begin reassembling the ship. Use the levitating gun in your inventory to begin putting the pieces of the ship together, like puzzle pieces.";
                highlightControls.HighlightRightTrigger();
                break;

            case 6:
                _UI_Panel_Text4.text = "Looks like everything is fixed! But, one of the components is broken - the thrusters.Now you must program the ship. Move to the codeblock that adds 10 amps of thrust to the system, to program the ship to begin moving forward. ";
                break;

            case 7:
                _UI_Panel_Text5.text = "Your work here is almost done!! Now, you must deposit the aliens into their ship, to begin moving the aliens forward in motion.Reactivate the Oxygen Cylinder and bring it as close as you can, until it touches the chair in the cockpit.";
                highlightControls.HighlightRightTrigger();
                highlightControls.DisableHighlightLeftJoystick();
                break;
        }
    }

}
