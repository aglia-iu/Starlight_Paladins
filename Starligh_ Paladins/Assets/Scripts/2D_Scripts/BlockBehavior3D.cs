using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockBehavior3D : MonoBehaviour
{
    public delegate void DragEndedDelegate(BlockBehavior3D blockObject);
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
}
