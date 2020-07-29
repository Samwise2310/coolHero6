using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inkPlayerMovement : MonoBehaviour
{

    // Declaring Variabals
        // playerSpeed controls how fast the player can move
    public float playerSpeed = 5;

        // Referencing the animator
    public Animator animator;

        // Enemy transform is so I can always be looking at the enemy
    public Transform enemyTransform;

    public string pauseButtonSceneToLoad;

        // Spot Light
    public GameObject spotLight;
        // Candle Lights
    public GameObject candleLights;



    void Start()
    {
        // candleLights.SetActive(false);

        Invoke("lights", 15f);


        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }



    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal");
        moveDir.z = Input.GetAxis("Vertical");
        moveDir.y = Input.GetAxis("Jump");

        transform.position += moveDir * playerSpeed * Time.deltaTime;


            // Calling the playerAnimation() function below
        playerAnimation(); // Made this into a function just for organizational reasons


            // Claling the lookAt() function
        lookAt();




        // Puase game
        if (Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene("mainMenu");
        }

        // Fail-Safe library return
        if (Input.GetKeyDown("m"))
        {
            SceneManager.LoadScene("LibraryWhitebox");
        }
    }



    // Taking care of all of the player animation things
    void playerAnimation()
    {


        // Setting up running animation
        // Inside of the running animation is an if statement that checks to see if the player has fired while running
        if (Input.GetButton("Horizontal"))
        {
            animator.SetBool("isRunning", true);
            // Debug.Log("Is running set to true from Horizontal");

            if (Input.GetMouseButton(0))
            {
                animator.SetBool("isRunning_isShooting", true);
                // Debug.Log("If in mouse down in horizontal if - set isRunning_isShooting - true");
            }
            else
            {
                animator.SetBool("isRunning_isShooting", false);
                // Debug.Log("else in mouse down in horizontal if - set isRunning_isShooting - false");
            }
        }
        else if (Input.GetButton("Vertical"))
        {
            animator.SetBool("isRunning", true);
            // Debug.Log("Is running set to true from Vertical");

            if (Input.GetMouseButton(0))
            {
                animator.SetBool("isRunning_isShooting", true);
                // Debug.Log("If in mouse down in vertical if - set isRunning_isShooting - true");
            }
            else
            {
                animator.SetBool("isRunning_isShooting", false);
                // Debug.Log("Else in mouse down in Vertical if - set isRunning_isShooting - false");
            }
        }
        else
        {
            animator.SetBool("isRunning", false);

            //    Debug.Log("Is running set to false");


            if (Input.GetMouseButton(0))
            {
                animator.SetBool("isStanding_isShooting", true);
                // Debug.Log("set isStanding_isShooting - true from if mouse down statement in else on running statement");
            }
            else
            {
                animator.SetBool("isStanding_isShooting", false);
                // Debug.Log("Set isStanding_isShooting - false from if mouse down statement in else on running statement");
            }
        }
    }



    /*
     * This lookAt() funciton will turn the player to always be facing the Enemy
     */
    private void lookAt()
    {
        Vector3 direction = enemyTransform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }



    void lights()
    {
        spotLight.SetActive(false);

        candleLights.SetActive(true);
    }








}
