using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class britta : MonoBehaviour
{

    // Declaring Variabals
        // Britta
    public GameObject brittaGO;
        // Animator
    public Animator animator;
        // Game Object - brittaComeOut
    public GameObject brittaComeOut;





    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            // Do Something
            animator.SetBool("brittaWalkingOut", true);
            Invoke("brittaWalkingOutOff", 3.2f);
            brittaComeOut.SetActive(false);
        }

    }


    void brittaWalkingOutOff()
    {
        animator.SetBool("brittaWalkingOut", false);
    }







}
