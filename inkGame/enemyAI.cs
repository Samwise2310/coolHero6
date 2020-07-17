using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class enemyAI : MonoBehaviour
{


    public Transform target;


    public float speed = 200f;
    public float nextWaypointDistance = 3f;


    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody>();

        // the Invoke Repeating updates the path, the last option is how often you want it to update
        InvokeRepeating("UpdatePath", 0f, .5f);
        
    }

    // This updates the path that the Enemy Character is taking. Its update rate is set by the Invoke Repeating in the Start() function
    void UpdatePath()
    {
        if (seeker.IsDone())
        seeker.StartPath(rb.position, target.position, OnPathComplete);

    }

    // This checks to see if the Enemy Character has reached the end of the path on which he was traveling. 
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }



    // FixedUpdate is called at set intervals
    void FixedUpdate()
    {
        if (path == null)
            return;

        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }


        Vector3 direction = ((Vector3)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector3 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector3.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }

    }

    // This is supposed to make the Enemy jump over obstacles
    // Creating public variable so I can adjust the jump force in Unity
    public float jumpForce = 20;
    // When enemy collides with the trigger box set up on a platform he will then jump
    void OnTriggerEnter (Collider col)
    {
        switch (col.tag)
        {
            case "inkGameObstacle": //Change this to name of Tag of what you want to jump over
                rb.AddForce(Vector3.up * jumpForce);
                break;  

        }
    }




}
