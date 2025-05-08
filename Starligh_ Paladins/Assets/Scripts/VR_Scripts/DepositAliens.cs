using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class DepositAliens : MonoBehaviour
{
    [SerializeField] private GameObject spaceAliens;
    [SerializeField] private GameObject graphic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "jar")
        {
            spaceAliens.SetActive(true);
            
            List<GameObject> axolotls = new List<GameObject>();
            other.gameObject.GetChildGameObjects(axolotls);
            foreach(GameObject axolotl in axolotls)
            {
                axolotl.SetActive(false);
            }
            graphic.SetActive(true);
            //other.gameObject.SetActive(false);
        }
    }
}
