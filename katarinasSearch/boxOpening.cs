using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxOpening : MonoBehaviour
{

    // Declaring Variabals
        // boxRenderer
    private Renderer boxRenderer;
        // Sorting order base
    public int sortingOrderBase = 5000;
        // Decalring offset
    public int offset = 0;
        // Decarling bool - Box Opened
    public bool boxOpened = false;




    private void Awake()
    {
        boxRenderer = gameObject.GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        if (boxOpened)
        {
            boxRenderer.sortingOrder = (int)(sortingOrderBase + offset);

        }
    }




}
