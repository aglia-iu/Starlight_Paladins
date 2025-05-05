using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Block_Behavior_2D : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
    //IDragAndDropHandler
{
    public delegate void DragEndedDelegate(Block_Behavior_2D blockObject);
    public DragEndedDelegate dragEndedCallback;

    public bool codeSnap = false;
    public bool codeBlocks = false;

    private Canvas canvasParent;
    public Transform visualTarget;
    public Vector3 localAxis;

    private Vector3 offset;
    private bool _isDragged = false;

    void Start()
    {
        offset = Vector3.zero;
        canvasParent = GetComponentInParent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (codeBlocks
            && codeSnap
            )
        {
            Debug.Log("Begin Drag");
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Dragging");
        if (codeBlocks 
            && codeSnap
            )
        {
            this.transform.position = Input.mousePosition - offset;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (codeBlocks 
            && codeSnap
            )
        {
            Debug.Log("End Drag");
            _isDragged = false;
            dragEndedCallback(this);
        }
            

    }
    private void OnMouseUp()
    {
        if (codeBlocks 
            && codeSnap
            )
        {
            Debug.Log("Mouse Up");
            _isDragged = false;
            dragEndedCallback(this);
        }
            
    }
   
    void Update()
    {
        //offset = this.transform.position - (Input.mousePosition);
    }

    // XR VARIABLES
    //private Transform pokeAttachTransform;
    //private XRBaseInteractable _interactable;

    // Start is called before the first frame update
    

    //public void Follow(BaseInteractionEventArgs hover)
    //{
    //    if (hover.interactorObject is XRPokeInteractor)
    //    {
    //        XRPokeInteractor interactor = (XRPokeInteractor)hover.interactorObject;
    //        _isFollow = true;
    //        pokeAttachTransform = interactor.attachTransform;
    //        offset = visualTarget.position - pokeAttachTransform.position;
    //    }
    //}
    // Update is called once per frame
    //void Update()
    //{
    //    if (_isFollow)
    //    {
    //        //visualTarget.position = pokeAttachTransform.position + offset;
    //        //visualTarget.localPosition = new Vector3(visualTarget.localPosition.x, visualTarget.localPosition.y, 0);
    //        visualTarget.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
    //    }
    //}

    //public void OnMouseDown()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        _isFollow = true;
    //        offset = visualTarget.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        Debug.Log("Offset: " + offset);
    //        //visualTarget.localPosition = new Vector3(visualTarget.localPosition.x, visualTarget.localPosition.y, 0);
    //    }
        
    //}

    //public void OnMouseDrag()
    //{
    //    visualTarget.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
    //    Debug.Log("This Button: " + visualTarget.transform.position);
    //}
    
    

}
