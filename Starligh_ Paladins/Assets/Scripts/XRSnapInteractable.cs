using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * The XR Snap Interactable class is used to set snap functionality. This script is to be attached to a 3D GameObject with a disabled mesh, such as a 
 * small sphere or pyramid (tagged as the 'SnapPoint'). These spheres or pyramids are then added to each side of the object, with a different tag for 
 * each side depending on the feature (for example, for sides with different colors, the faceTag for each object may be 'green', 'red' or 'blue'.) Using this class, users can snap two faces on two different objects together, so that a user can connect two objects. 
 * **/
public class XRSnapInteractible : XRSocketInteractor
{
    // PUBLIC VARIABLES
  
    public string faceTag; // The face of the object and it's tag
    public GameObject correct;
    public GameObject wrong;

    // PRIVATE VARIABLES
    private bool connected = false; // The state of the face, i.e. if it is connected or not. 

    /**
     * When the parentObject of the snapPoint is selected, other snap points are highlighted.
     **/
    
    public override bool CanHover(IXRHoverInteractable interactable)
    {
        if (ConnectFacesHover(interactable))
        {
            correct.SetActive(true);
            wrong.SetActive(false);
        }
        else
        {
            correct.SetActive(false);
            wrong.SetActive(true);
        }
        return base.CanHover(interactable) && ConnectFacesHover(interactable);       
        
    }
    public override bool CanSelect(IXRSelectInteractable interactable)
    {
       if (ConnectFacesSelect(interactable))
       {
            correct.SetActive(true);
            wrong.SetActive(false);
        }
       else
       {
            correct.SetActive(false);
            wrong.SetActive(true);
        }
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
