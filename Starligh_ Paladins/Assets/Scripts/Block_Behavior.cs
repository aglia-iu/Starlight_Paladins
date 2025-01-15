using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Block_Behavior : MonoBehaviour
{
    public Transform visualTarget; 
    
    private Vector3 offset;
    private Transform pokeAttachTransform;
    
    private XRBaseInteractable _interactable;
    private bool _isFollow = false;

    // Start is called before the first frame update
    void Start()
    {
        _interactable = GetComponent<XRBaseInteractable>();
        _interactable.hoverEntered.AddListener(Follow);
    }

    public void Follow(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            XRPokeInteractor interactor = (XRPokeInteractor)hover.interactorObject;
            _isFollow = true;
            pokeAttachTransform = interactor.attachTransform;
            offset =  visualTarget.position - pokeAttachTransform.position; 
        }
    } 
    // Update is called once per frame
    void Update()
    {
        if (_isFollow)
        {
            
            visualTarget.position = pokeAttachTransform.position + offset;
        }
    }
}
