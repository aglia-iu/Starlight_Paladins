using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] GameObject UI_Panel_Complete;
    [SerializeField] GameObject[] snapPoints;
    private int inactiveComponents;
    // Start is called before the first frame update
    void Start()
    {
        CollectAllSnapPoints();  
    }

    // Update is called once per frame
    void Update()
    {
        CheckSnapPoints();
    }

    void CollectAllSnapPoints()
    {
        snapPoints = GameObject.FindGameObjectsWithTag("snapPoint");
       
    }

    void CheckSnapPoints()
    {
        if (inactiveComponents >= 1)
        {
            UI_Panel_Complete.SetActive(true);
        }
        foreach (GameObject snapPoint in snapPoints)
        {
            XRSnapInteractible snapPointInteractable = snapPoint.GetComponent<XRSnapInteractible>();
            if (snapPointInteractable != null)
            {
                if (snapPointInteractable.socketActive)
                {
                    Debug.Log(snapPoint.gameObject.name + " is active!");
                    //return;
                }
                else
                {
                    Debug.Log(snapPoint.gameObject.name + " is inactive!" + inactiveComponents);
                }
            }
            else
            {
                Debug.Log("Couldn't acquire XRSnapInteractible for " + snapPoint.gameObject.name);

            }
        }

        if(inactiveComponents >= 12)
        {
            UI_Panel_Complete.SetActive(true);
        }
        
    }

    public void ActivatedComponents()
    {
        inactiveComponents++;
    }
    
}
