using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBallFire : MonoBehaviour
{



    //Declaring Variables
        // This will let me pass the cannonBall object into the scene
    public GameObject cannonBall;
        // Transform of cannonBall (tomato)
    public Transform cannonBallTransform;
        // Speed of the cannonBall
    public float Speed = 20f;
        // Speed1 is the Random speed that the ball is launched at
    public float Speed1 = 0f;
        // Right controls the left/right angle that the ball is launched at
    public float Right = 0f;
        // Vertical
    public float Vertical = 20f;
        // Here I can pass in the Rigidbody of the cannonBall
    public Rigidbody rb;
        // This will be the target position
    public Vector3 targetPos;
        // Starting Position will hold the start position if I need it
    public Vector3 startPos;
        // This will hold the Random Value that will throw objects.
    public float rand = 3f;

        // Damage will hold the amount of damage this will deal if it hits the player
    public float damage = 50f;

        // This Rigidbody will hold the rigidbody of the each clone
    public Rigidbody tempRigidbody;

    public GameObject clone;


    public GameObject tomatoSplat;
    public Transform tomatoSplatTransform;
    public GameObject tempTomato;




    // Start is called before the first frame update
    void Start()
    {

        Invoke("fire", rand);


    }



    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("Colliding on object: " + collision.gameObject.tag);

        if (collision.gameObject.tag == "Stage")
        {
            tempTomato = Instantiate(tomatoSplat);

            tomatoSplatTransform.position = cannonBallTransform.position;


          //  tempTomato = clone.GetComponent<GameObject>();
           Destroy(tempTomato, 3f);

            // print("Collided with the Stage - This is my print");
            Destroy(gameObject, 0f);
            // Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0f);
        }


    }



    // Fire is called every (random)
    void fire()
    {

        clone = Instantiate(cannonBall);  


        Destroy(clone.gameObject, rand - 0.01f);




        tempRigidbody = clone.GetComponent<Rigidbody>();




            // This Invoke is invoking the fire function every rand time
       Invoke("fire", rand);
       
            // This is randomizing the time between shots
        rand = Random.Range(1f, 10f);
       // print("Rand = " + rand);
            // This is Randomizing the foward speed
        Speed1 = Random.Range(120f, 250f);
       // print("Speed1 = " + Speed1);
            // This is Randomizing the Vertical velocity
        Vertical = Random.Range(200f, 225f);
       // print("Vertacle = " + Vertical);
            // This is Randomizing the left/right "angle"
        Right = Random.Range(-50f, 50f);
       // print("Right Random = " + Right);


            // Adding force to the RigidBody of the object
        tempRigidbody.AddForce(transform.forward * Speed1);    // Forward
        tempRigidbody.AddForce(transform.up * Vertical);       // Up
        tempRigidbody.AddForce(transform.right * Right);       // Left/Right


    }
      

}
