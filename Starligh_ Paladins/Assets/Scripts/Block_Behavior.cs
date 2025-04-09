using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Block_Behavior : MonoBehaviour
{
    public delegate void DragEndedDelegate(Block_Behavior blockObject);
    public DragEndedDelegate dragEndedCallback;

    public bool codeSnap = false;
    public bool codeBlocks = false;

    private Canvas canvasParent;
    public Transform visualTarget; 
    public Vector3 localAxis;
    
    private Vector3 offset;
    private Transform pokeAttachTransform;
    
    private XRBaseInteractable _interactable;
    private bool _isFollow = false;
    //private bool _isDragged = false;

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
        else
        {
            _isFollow = false;
        }
    } 
    // Update is called once per frame
    void Update()
    {
        if (_isFollow)
        {
            visualTarget.position = pokeAttachTransform.position + offset;
            visualTarget.localPosition = new Vector3(visualTarget.localPosition.x, visualTarget.localPosition.y, 0);
        }
    }
}
