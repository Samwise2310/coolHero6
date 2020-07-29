using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class enemyAI : MonoBehaviour
{

    // Declaring Variabals
        // Target holds the players position
    public Transform target;

        // Speed holds the speed of the Enemy
    public float speed = 200f;
    public float nextWaypointDistance = 3f;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody rb;

        // This will hold the Enemys GameObject so I can get his rotation etc. 
    public GameObject EnemyGO;


    //Declaring Variabals for the Shoot Functions
        // Rnage will tell the Raycast how far to go
    float range = 100f;
        // Damage holds how much damage will be dealt to the enemy
    public int damage = 20;
        // Getting gameObject enemyShootPoint which is the tip of the pen
    public GameObject enemyShootPoint;

    // Variablas for animation
        // Refferencing the animator
    public Animator animator;
        // enemyAnimationTime
    float enemyAnimationTime = 3f;
        // enemyAnimationTimeReset
    float enemyAnimationTimeReset = 1f;
        // muzzleFlash plug in
    public ParticleSystem muzzleFlash;
        // animation delay for camera movement before enemy starts firing
    float animationDelay = 20f;






    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody>();

        // the Invoke Repeating updates the path, the last option is how often you want it to update
        InvokeRepeating("UpdatePath", 20f, 3f);

        InvokeRepeating("Shoot", 25f, 0.5f); // Maybe change the time between invokes to be random

        // InvokeRepeating("enemyAnimation", 0f, 3f);

        Invoke("showsHint", 8f);

    }

    // Update is called once every frame
    void Update()
    {
        lookAt();

        enemyAnimation();
    }




    // This updates the path that the Enemy Character is taking. Its update rate is set by the Invoke Repeating in the Start() function
    void UpdatePath()
    {
        if (seeker.IsDone())
        seeker.StartPath(rb.position, target.position, OnPathComplete);




            // Checking to make sure that the enemyShootPoint location updates like it should
        // Debug.Log("enemyShootPoint location is: " + enemyShootPoint.transform.position);

            // Seeing if getting the players position is this easy. UPDATE: It was
        // Debug.Log("This is the target.position " + target.position);
        // Debug.Log("This is the target.position.x " + target.position.x);
            // Seeing if getting the Enemys position is this easy. UPDATE: It was
        // Debug.Log("This is the rb.position.. IDK if this will work " + rb.position);

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




    /*
     *                  Comment sections for Shoot() function
     * This is where I will use a Raycast to see if I hit the player character
     * I will also need to randomize the enemys accuracy
     *      I will do that by: Getting the players x, y, & z position and then
     *      adding a random number to that number within a range that I can set
     *      in unity.
     *      So for example it should look something like
     *              playerPositionX + randomNumber1
     *              playerPositionY + randomNumber2
     *              playerPositionZ + randomNumber3
     *              
     *              Raycast from enemyPosition to playerPositionRandom
     *   *** I do not know if the above note will work. I have not tested anything
     *       this is just my thought process on maybe how to get this done ***
     *      
     *      
     *      *** Tested & Works ***
     *  You can get the players position by typing: target.position
     *  You can get the Enemys position by typing: rb.position
     *  
     *  Changed the enemys fire position to enemyShootPoint.transform.position
     *      I made a small sphere collider at the tip of the enemys pen to have
     *      as a reference for where to shoot from.
     */
    void Shoot()
    {
        // Debug.Log("Shoot() function has been called");

        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(enemyShootPoint.transform.position, target.position, out hit, range))
        {
            Debug.Log("Enemy Hit: " + hit.transform.name);

            // Here I will call in a reference to the Target script to apply "damage" to the player
            playerDamage playerDamage = hit.transform.GetComponent<playerDamage>();
            if (playerDamage != null)
            {
                playerDamage.TakeDamage(damage);
            }


        }
    }




    /*
     * This lookAt() function will turn the Enemy to always be facing the player
     */
    void lookAt()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }



    /*
     * enemyAnimation() is where I will call all of the animations and
     * set them true/false accordingly
     * 
     */
    void enemyAnimation()
    {


        if (animationDelay >= 0)
        {
            animationDelay -= Time.deltaTime;

        }
        else if (animationDelay < 0)
        {

            if (enemyAnimationTime >= 0f)
            {
                enemyAnimationTime -= Time.deltaTime;
                    //Debug.Log("EnemyAnimationTime = " + enemyAnimationTime);
                animator.SetBool("isRunning", true);
            }
            else if (enemyAnimationTime < 0f)
            {
                    //Debug.Log("Reached the else if statement in enemyAnimation()");
                animator.SetBool("isRunning", false);



                if (enemyAnimationTimeReset >= 0f)
                {
                        //Debug.Log("Made it to enemyAnimationTimeReset if - ");
                    enemyAnimationTimeReset -= Time.deltaTime;
                        //Debug.Log("enemyAnimationTimeReset is: " + enemyAnimationTimeReset);
                    animator.SetBool("isRunning_isShooting", true);
                }
                else if (enemyAnimationTimeReset < 0f)
                {
                    //Debug.Log("Made it to the enemyAnimationTimeReset else if - ");
                    animator.SetBool("isRunning_isShooting", false);

                    enemyAnimationTime = 1;

                    enemyAnimationTimeReset = 1f;
                }



            }
        }

    }

    void showsHint()
    {
        animator.SetBool("showsHint", true);

        Invoke("showsHintOff", 5f);
    }

    void showsHintOff()
    {
        animator.SetBool("showsHint", false);
    }




}
