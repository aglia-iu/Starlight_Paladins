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

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("I collided!");
        if (other.gameObject.tag == "axolotl")
        {
            Debug.Log("Caught an aliens!");
            other.gameObject.transform.SetParent(this.transform);
            other.gameObject.transform.localScale *= 0.1f;
            other.gameObject.transform.localPosition = Vector3.zero;
            
        }
    }
}
