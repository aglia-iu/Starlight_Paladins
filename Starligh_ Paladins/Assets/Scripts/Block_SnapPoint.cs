using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Block_SnapPoint : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<Block_Behavior_2D> draggableObjs;
    public float snapRange = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        CollectBlocksofType();
    }

    void Update()
    {
        CollectBlocksofType();
        foreach (Block_Behavior_2D block in draggableObjs)
        {
            block.dragEndedCallback = OnDragEnded;
        }
    }

    private void OnDragEnded(Block_Behavior_2D block)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
            if (snapPoint.transform != block.transform)
            {
                float currentDistance = Vector2.Distance(
                block.transform.localPosition,
                snapPoint.localPosition
                );
                if (closestSnapPoint == null || currentDistance < closestDistance)
                {
                    closestSnapPoint = snapPoint;
                    closestDistance = currentDistance;
                }
            }
        }
        Debug.Log("Closest Snap!");
        Debug.Log(closestSnapPoint);
        Debug.Log(closestDistance);
        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            block.transform.localPosition = closestSnapPoint.localPosition;
        }
    }

    private void CollectBlocksofType()
    {
        GameObject[] blockObjects = GameObject.FindGameObjectsWithTag("codeBlocks");
        foreach (GameObject blockObject in blockObjects)
        {
            if (!snapPoints.Contains(blockObject.transform) && blockObject.GetComponent<Block_Behavior_2D>().codeSnap)
            {
                snapPoints.Add(blockObject.transform);
            }
            else if (!draggableObjs.Contains(blockObject.GetComponent<Block_Behavior_2D>()) && blockObject.GetComponent<Block_Behavior_2D>().codeBlocks)
            {
                draggableObjs.Add(blockObject.GetComponent<Block_Behavior_2D>());
            }

        }
        //GameObject[] blockObjects = GameObject.FindGameObjectsWithTag("codeBlocks");
        //foreach (GameObject blockObject in blockObjects)
        //{
        //    if (!draggableObjs.Contains(blockObject.GetComponent<Block_Behavior_2D>()))
        //    {
        //        draggableObjs.Add(blockObject.gameObject.GetComponent<Block_Behavior_2D>());
        //    }
        //}
    }
}
