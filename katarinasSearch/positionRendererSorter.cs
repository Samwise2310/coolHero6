using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionRendererSorter : MonoBehaviour
{


    // Declaring Variablals
        // Declaring Renderer
    private Renderer myRenderer;
        // Declaring Sorting order base
    public int sortingOrderBase = 5000;
        // Declaring offset
    public int offset = 0;
        // Declaring a bool to run the script only once on certain objects
    public bool runOnlyOnce = false;




    private void Awake()
    {
        myRenderer = gameObject.GetComponent<Renderer>();

    }


    private void LateUpdate()
    {
        myRenderer.sortingOrder = (int)(sortingOrderBase - transform.position.z - offset);
        if (runOnlyOnce)
        {
            Destroy(this);
        }
    }


   
}
