using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomato : MonoBehaviour
{


    // Declaring Variables
        // This will let me pass the Tomato object into the scene
    public GameObject Tomato;
        // Force the Tomato is thrown (Will be random)
    float Force = 20f;
        // Right controls the left/right angle the the tomato will be launched
    float Right = 0f;
        // Vertical holds the random vertical input
    float Vertical = 0f;
        // Here I can pass the Rigidbody of the tomato in unity
    public Rigidbody rb;
        // This will hold the Random Value that will throw objects
    float rand = 3f;

        // This will hold the temp rigidbody of the tomatoe clone
    Rigidbody tempRigidbody;
        // This will hold the clone of the tomato
    GameObject clone;

        // Damage will handle how much damage is dealt
    public float Damage = 50f;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("fire", rand);

        rand = Random.Range(1f, 10f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void fire()
    {

        clone = Instantiate(Tomato);

        Destroy(clone.gameObject, rand - 0.01f);


        tempRigidbody = clone.GetComponent<Rigidbody>();


        // This Invoke is invoking the fire function every rand time
        Invoke("fire", rand);

        // This is randomizing the time between shots
        rand = Random.Range(1f, 10f);
        // This is Randomizing the force
        Force = Random.Range(120f, 250f);
        // This is Randomizing the Vertical Velocity
        Vertical = Random.Range(200f, 225f);
        // This is Randomizing the left/right "Angle"
        Right = Random.Range(-50f, 50f);


        // Adding force to the RigidBody of the object
        tempRigidbody.AddForce(transform.forward * Force);      // Forward
        tempRigidbody.AddForce(transform.up * Vertical);        // Up
        tempRigidbody.AddForce(transform.right * Right);        // Left/Right


    }




}
