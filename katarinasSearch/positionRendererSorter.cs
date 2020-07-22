﻿using System.Collections;
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



    private void Awake()
    {
        myRenderer = gameObject.GetComponent<Renderer>();

    }


    private void LateUpdate()
    {
        myRenderer.sortingOrder = (int)(sortingOrderBase - transform.position.y - offset);
    }


   
}