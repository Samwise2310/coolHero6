using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prefabShooting : MonoBehaviour
{

    // Setting up Variables
        // This will be the bullet object. (Not 100% sure if this is right 
    public GameObject theBullet;
        // This is the speed of the "bullet"
    public float Speed = 20f;
        // This is the positino of the Character that is shooting
    public GameObject characterPos;
        // This is the position of the target
    public Transform targetPos; // NOT USED YET
        // I do not know if I will need to get the Rigidbody
    public Rigidbody rb;
        // This Vector 3 variable will hold the mouse position
    private Vector3 worldPosition;
        // Mouse position on mouse click
    private Vector3 mouseClickPos;
        // Creating variable "toTransform"
    private Vector3 toTransform;
        // Creating a variabal to hold the muzzle flash
    public ParticleSystem muzzleFlash;
        // Ink Impact Effect
    public GameObject impactEffect;




    public int damage = 10;

    public float range = 100f;
  

  






    // Start is called before the first frame update
    void Start()
    {
        // Gets the players current position
        if (characterPos == null)
            characterPos = GameObject.Find("player");


        rb = GetComponent<Rigidbody>();
        


    } // End of Void Start





// This update is called every frame
// I think I will want a FixedUpdate() here but I am not sure yet.
void Update()
    {

     


        /* 
         * This Vector3 converts the characterPos from a GameObject to a Vector3
         * Because for me to do the next step you can not subtract a
         * Vector3 from a GameObject so they both needed to be of type Vector3 
         */

        toTransform = characterPos.transform.position;

        

        /*
         * This section of code will handle the Mouse Position
         * I will be getting the information on this from 
         * https://gamedevbeginner.com/how-to-convert-the-mouse-position-to-world-space-in-unity-2d-3d/#screen_to_world_3d 
         */

        Plane plane = new Plane(Vector3.up, 0);

        float distance;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        } // End of Mouse Position Collection


        /*
         * This section will handle the mouse position when the player
         * clicks the left mouse button. This will then be passed for
         * the target location of the "bullet" that the player will
         * be firing at the enemy.
         */

        if (Input.GetMouseButtonDown(0))
        {
            mouseClickPos = worldPosition;
            // Debug.Log("Mouse Clicked at Position " + mouseClickPos); // This is just printing on the console what the position of my mouse click is for a checker to see if it is working correctly
        }


        /*
         * This section will handle the target position of where 
         * I want the bullet to fly too. 
         * 
         * I am using the equation I found at the link below. It says that
         * Quaternion.LookRotation gives you a rotation that looks in a certain direction
         * which I should be able to point my "bullet" object in a cartain direction and
         * then just apply a velocity/speed to that object to have go where I want it too.
         * 
         * They also go on to say that To get a vector that points from point a to point b, do b - a:
         * So that would look something like
         * Vector3 a = new Vector3(1, 1, 1);
         * Vector3 b = new Vector3(5, 1, 1);
         * Vector3 aTob = b - a; // (Gives (4, 0, 0);
         * 
         * Where a = spawnPoint
         * b = targetPoint
         * toTarget = targetPoint - spawnPoint
         * 
         * Which for me would be
         * a = toTransform
         * b = mouseClickPos
         * toTarget = mouseClickPos - toTransform
         * 
         * toTransform is set up in the void Start section
         * 
         * https://answers.unity.com/questions/981983/instantiate-a-projectile-facing-a-vector3-position.html
         */

        Vector3 toTarget = mouseClickPos - toTransform;

        if (Input.GetMouseButtonDown(0))
        {

            //    GameObject clone = Instantiate(theBullet, toTransform, Quaternion.LookRotation(toTarget));

            //    clone.transform.position = Vector3.MoveTowards(clone.transform.position, mouseClickPos, Time.deltaTime * Speed);

            //    Destroy(clone.gameObject, 3f);


            Shoot();

        }




        /*
         * The section below is going to handle the movement of the bullet object
         * in the direction of where the player clicks the mouse
         * 
         * Getting this code from:
         * https://low-scope.com/unity-quick-the-most-common-ways-to-move-a-object/
         * Section: USING VECTOR3.MOVETOWARDS
         */













        //    GameObject clone = Instantiate(theBullet, characterPos, Quaternion.LookRotation(toTarget));

        //    clone.velocity = transform.TransformDirection(Vector3(0, 0, Speed));

        //    Destroy(clone.gameObject, 3f);

        // toTarget is going to calculate the targetPoint - spawnPoint
        // Getting this information from https://answers.unity.com/questions/981983/instantiate-a-projectile-facing-a-vector3-position.html









        //       Vector3 bulletDirection = Vector3.zero;
        //       bulletDirection.x = (Input.mousePosition)
        //       bulletDirection.y = 
        //       bulletDirection.z = 



        // Puase game
        if (Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene("LibraryWhitebox");
        }




    }   // End of Update() function



    public void Shoot()
    {

        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(characterPos.transform.position, mouseClickPos, out hit, range));
        {
            Debug.Log("Player hit: " + hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }


            // Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));


        }


    }







    /*
     * 
     * This is the code that was taken from the
     * "Unity Shooting Tutorial (Raycast and Prefab)" Video on YouTube
     * https://www.youtube.com/watch?v=mpxim8YbsMk&t=1163s @time 3:48
     * Video is by Brackeys from April 10, 2013. Code does not work for
     * me currently. I have attempted to change where he had his objects 
     * set as "var" type and changed it to type "object". It is giving me
     * way to many errors to deal with so I am going to attempt to write
     * my own code to instatiate a bullet with the correct tragectory,
     * speed, etc. I am keeping this code down at the bottom becuase I
     * may need to reference it in the future.
     * 
     * 
     * 

        // Declaring variables
        object theBullet , Rigidbody;

        public float speed = 20;




        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                object clone = Instatiate(theBullet, transform.position, transform.rotation);

                clone.velocity = transform.TransformDirection(Vector3(0, 0, speed));

                Destroy(clone.gameObject, 3f);
            }
        }
    */



}
