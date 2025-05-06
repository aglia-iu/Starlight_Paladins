using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAliens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I collided!");
        if (collision.gameObject.tag == "axolotl")
        {
            Debug.Log("Caught an aliens!");
            collision.gameObject.transform.SetParent(this.transform);
            collision.gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
