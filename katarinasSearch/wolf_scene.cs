using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class wolf_scene : MonoBehaviour
{

    // Declaring Variabals
        // Animator
    public Animator animator;
        // Time is how long it takes the wolf to walk in
    public float time = 3.5f;
        // decisionTime is how long you have to chose what to do
    public float decisionTime = 5f;
        // blackScreenTime is how long the scene will last while you're being attacked
    public float blackScreenTime = .75f;
        // ButtonActive will hold a reference to the buttons
    public GameObject buttonActive;


    public GameObject deadWolf;


    void Start()
    {
        deadWolf.SetActive(false);

        buttonActive.SetActive(false);
    }




    void FixedUpdate()
    {
        if (time >= 0)
        {
            time -= (Time.deltaTime);
        }
        else if (time < 0)
        {
                // This sets "isPlaying" to false so that it will start to play the growl animation
            animator.SetBool("isPlaying", false);


                // This will activate the buttons
            buttonActive.SetActive(true);


                // This will start the attack if you don't make a choice fast enough
            if (decisionTime >= 0)
            {
                decisionTime -= (Time.deltaTime);
                Debug.Log("Decision Time = " + decisionTime);
            }
            else if (decisionTime < 0)
            {
                animator.SetBool("attack", true);

                if (blackScreenTime >= 0)
                {
                    blackScreenTime -= (Time.deltaTime);
                }
                else if (blackScreenTime < 0)
                {
                    Application.LoadLevel("katarinasSearch_deathState");
                }
            }
        }
    }




    public void wolfShot()
    {
        Invoke("destroyWolf", 1f);
    }

    void destroyWolf()
    {
        deadWolf.SetActive(true);

        Destroy(gameObject);
    }



}
