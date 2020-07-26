using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inkPlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5;

        // Importing the animator
    public Animator animator;



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
        
       





        // Puase game
        if (Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene("LibraryWhitebox");
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



    }
}
