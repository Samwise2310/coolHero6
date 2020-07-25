using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class river_scene02 : MonoBehaviour
{

    // Declaring Variabals
        // Animator
    public Animator animator;




    public void bridgeFallingAnimationStart()
    {
        animator.SetBool("bridgeReadyToFall", true);
    }




}
