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
    private Canvas canvasParent;
    public Transform visualTarget;
    public Vector3 localAxis;

    private Vector3 offset;
    private bool _isFollow = false;

    void Start()
    {
        offset = Vector3.zero;
        canvasParent = GetComponentInParent<Canvas>();
        //_interactable = GetComponent<XRBaseInteractable>();
        //_interactable.hoverEntered.AddListener(Follow);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        //offset = this.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

        this.transform.position = Input.mousePosition - offset;
        //transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");

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
