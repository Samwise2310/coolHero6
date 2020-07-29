using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{



    //Declaring Variables
        // This will let me pass the cannonBall object into the scene
    public GameObject cannonBall;
        // Force of the cannonBall (This is randomized later)
    float Force = 20f; //Speed is now Force
        // Right controls the left/right angle that the ball is launched at
    float Right = 0f;
        // Vertical
    float Vertical = 20f;
        // Here I can pass in the Rigidbody of the cannonBall
    public Rigidbody rb; // This is set to public so I can set it in unity
        // This will hold the Random Value that will throw objects.
    public float rand = 3f;
        // StartTime will hold the ammout of time before Fire is called the first time
    public float startTime = 30f;

        // This Rigidbody will hold the rigidbody of the each clone
    Rigidbody tempRigidbody;
        // This will hold the clone when passed through in Unity
    GameObject clone;


        // This variable will hold the delay before the bomb explodes
    public float delay = 3f;
        // This variable will hold the countdown before explosion
    float countdown;
        // This variable will hold a bool to know if the bomb has exploded
    bool hasExploded = false;





    // Start is called before the first frame update
    void Start()
    {
        // Invoking the fire() function
        Invoke("fire", startTime);

        // Randomizing the time between the next shot
        rand = Random.Range(1f, 10f);
        // print("Rand = " + rand);

        // Setting Countdown = to Delay
        countdown = delay;

    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void fire()
    {


        // This invokes the Explode() function
        Invoke("Explode", delay);




        // Instantiating the bomb as a clone
        clone = Instantiate(cannonBall);

        // Destroying the cloned object before instantiating it again
        Destroy(clone.gameObject, rand - 0.01f);



        // Saving the clones rigidbody in tempRigidbody
        tempRigidbody = clone.GetComponent<Rigidbody>();




        // This Invoke is invoking the fire function every rand time
        Invoke("fire", rand);

        // This is randomizing the time between shots
        rand = Random.Range(4f, 15f);
       // print("Rand = " + rand);
        // This is Randomizing the foward speed
        Force = Random.Range(120f, 250f);
       // print("Speed1 = " + Force);
        // This is Randomizing the Vertical velocity
        Vertical = Random.Range(200f, 225f);
       // print("Vertacle = " + Vertical);
        // This is Randomizing the left/right "angle"
        Right = Random.Range(-50f, 50f);
       // print("Right Random = " + Right);


        // Adding force to the RigidBody of the object
        tempRigidbody.AddForce(transform.forward * Force);      // Forward
        tempRigidbody.AddForce(transform.up * Vertical);        // Up
        tempRigidbody.AddForce(transform.right * Right);        // Left/Right


    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Stage")
        {
            Destroy(gameObject, 0f);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0f);
        }

    }


    void Explode()
    {
        // Debug.Log("BOOM!");


        // Show Effect

        // Get Nearby objects
            // Add force
            // Damage

        // Remove bomb

    }



}
