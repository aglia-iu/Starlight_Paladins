using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAttachVR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttachAfterHover(GameObject gameObject)
    {
        this.gameObject.transform.SetParent(gameObject.transform, false);
    }
}
