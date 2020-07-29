using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audienceHeckles : MonoBehaviour
{


    // Declaring Variabals
        // Animator
    public Animator animator;
        // Time between re-calling animations
    float stopTime = 3f;
        // Rand will hold a random number
    float randBoo;
        // Random number for Boo You Stink
    float randBooYouStink;
        // Random number for Get Off The Stage
    float randGetOffTheStage;
        // Random number for notFunny
    float randNotFunny;
        // Random number for takeThis
    float randTakeThis;
        // Random number for tastMyTomatoes
    float randTasteMyTomatoes;
        // Random number for dontTrustHim
    float randDontTrustHim;
        // Random number for bombsAreGood
    float randBombsAreGood;




    void Start()
    {
            // Boo
        randBoo = Random.Range(1f, 5f);
        Invoke("boo1", randBoo);
            // Boo You Stink
        randBooYouStink = Random.Range(2f, 10f);
        Debug.Log("randBooYouStink = " + randBooYouStink);
        Invoke("booYouStink", randBooYouStink);

            // Get Off The Stage
        randGetOffTheStage = Random.Range(4f, 30f);
        Invoke("getOffTheStage", randGetOffTheStage);
            // Not Funny
        randNotFunny = Random.Range(6f, 16f);
        Invoke("notFunny", randNotFunny);
            // Take This
        randTakeThis = Random.Range(10f, 15f);
        Invoke("takeThis", randTakeThis);
            // Taste My Tomatoes
        randTasteMyTomatoes = Random.Range(12f, 18f);
        Invoke("tasteMyTomatoes", randTasteMyTomatoes);
            // Don't Trust Him
        randDontTrustHim = Random.Range(45f, 55f);
        Invoke("dontTrustHim", randDontTrustHim);
            // Bombs Are Good
        randBombsAreGood = Random.Range(35f, 45f);
        Invoke("bombsAreGood", randBombsAreGood);

    }


    void boo1()
    {
            // Set booBool to true
        animator.SetBool("booBool", true);
            // booStop() is going to set booBool to false
        Invoke("boo1Stop", stopTime);
            // randomizing rand again so each time boo1 is called it's different
        randBoo = Random.Range(3f, 45f);
            // Invoking this boo1() function again
        Invoke("boo1", randBoo);
    }

    void boo1Stop()
    {
        animator.SetBool("booBool", false);
    }

    void booYouStink()
    {
        animator.SetBool("booYouStink", true);

        randBooYouStink = Random.Range(3f, 45f);

        Invoke("booYouStink", randBooYouStink);

        Invoke("booYouStinkStop", stopTime);
    }

    void booYouStinkStop()
    {
        animator.SetBool("booYouStink", false);
    }

    void getOffTheStage()
    {
        animator.SetBool("getOffTheStage", true);

        randGetOffTheStage = Random.Range(10f, 30f);

        Invoke("getOffTheStage", randGetOffTheStage);

        Invoke("getOffTheStageStop", stopTime);
    }

    void getOffTheStageStop()
    {
        animator.SetBool("getOffTheStage", false);
    }

    void notFunny()
    {
        animator.SetBool("notFunny", true);

        randNotFunny = Random.Range(10f, 45f);

        Invoke("notFunny", randNotFunny);

        Invoke("notFunnyStop", stopTime);
    }

    void notFunnyStop()
    {
        animator.SetBool("notFunny", false);
    }

    void takeThis()
    {
        animator.SetBool("takeThis", true);

        randTakeThis = Random.Range(12f, 59f);

        Invoke("takeThis", randTakeThis);

        Invoke("takeThisStop", stopTime);
    }

    void takeThisStop()
    {
        animator.SetBool("takeThis", false);
    }

    void tasteMyTomatoes()
    {
        animator.SetBool("tasteMyTomatoes", true);

        randTasteMyTomatoes = Random.Range(10f, 55f);

        Invoke("tasteMyTomatoes", randTasteMyTomatoes);

        Invoke("tasteMyTomatoesStop", stopTime);
    }

    void tasteMyTomatoesStop()
    {
        animator.SetBool("tasteMyTomatoes", false);
    }

    void dontTrustHim()
    {
        animator.SetBool("dontTrustHim", true);

        randDontTrustHim = Random.Range(15f, 50f);

        Invoke("dontTrustHim", randDontTrustHim);

        Invoke("dontTrustHimStop", stopTime);

    }

    void dontTrustHimStop()
    {
        animator.SetBool("dontTrustHim", false);
    }

    void bombsAreGood()
    {
        animator.SetBool("bombsAreGood", true);

        randBombsAreGood = Random.Range(15f, 30f);

        Invoke("bombsAreGood", randBombsAreGood);

        Invoke("bombsAreGoodStop", stopTime);
    }

    void bombsAreGoodStop()
    {
        animator.SetBool("bombsAreGood", false);
    }

}
