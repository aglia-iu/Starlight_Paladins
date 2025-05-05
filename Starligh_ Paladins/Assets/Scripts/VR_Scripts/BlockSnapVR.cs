using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BlockSnapVR : XRSocketInteractor
{
    // PUBLIC VARIABLES

    public string faceTag; // The face of the object and it's tag

    // PRIVATE VARIABLES
    private bool connected = false; // The state of the face, i.e. if it is connected or not. 

    /**
     * When the parentObject of the snapPoint is selected, other snap points are highlighted.
     **/

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable) && ConnectFacesHover(interactable);

    }
    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && ConnectFacesSelect(interactable);

    }

    /**
     * If two points have the same face names, then snap those two points together. **/
    private bool ConnectFacesHover(IXRHoverInteractable interactable)
    {

        return interactable.transform.gameObject.CompareTag(faceTag);
    }

    private bool ConnectFacesSelect(IXRSelectInteractable interactable)
    {

        return interactable.transform.gameObject.CompareTag(faceTag);
    }
}
