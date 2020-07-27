using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePlayer_jokeBook : MonoBehaviour
{


    // Declaring Variabals
        // Animator
    public Animator animator;
        // Time before Cheesy Start Walking over
    private float cheesyStartWalkingTimer = 0.42f;
        // Time before Cheesy Stop Walking over
    private float cheesyStopWalkingTimer = 0.42f;




   
        float speed = 5;

        // Update is called once per frame
        void Update()
        {
            Vector3 moveDir = Vector3.zero;
            moveDir.x = Input.GetAxis("Horizontal");
            moveDir.z = Input.GetAxis("Vertical");
            
            transform.position += moveDir * speed * Time.deltaTime;




            cheesyAnimation();
            
            
            
            
            
            
            
            
            // Puase game
            if (Input.GetButtonDown("Pause"))
            {
                SceneManager.LoadScene("LibraryWhitebox");
            }


        }



    /*
     * Cheesy Animations
     */
    void cheesyAnimation()
    {

        if (Input.GetButton("Horizontal"))
        {
            // Debug.Log("Set cheesyWalking to True");
            animator.SetBool("cheesyWalking", true);
        }
        else if (Input.GetButton("Vertical"))
        {
            animator.SetBool("cheesyWalking", true);
        }
        else
        {
            // Debug.Log("Set cheesyWalking to False");
            animator.SetBool("cheesyWalking", false);
        }



        /*
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("cheesyStartWalking  = true");
            animator.SetBool("cheesyStartWalking", true);

            if (cheesyStartWalkingTimer < 0)
            {
                Debug.Log("cheesyWalking = true");
                animator.SetBool("cheesyWalking", true);
            }
        }
        else if (Input.GetButton("Vertical"))
        {
            animator.SetBool("cheesyStartWalking", true);
        }
        else
        {
            Debug.Log("cheesyStartWalking = false");
            animator.SetBool("cheesyStartWalking", false);
        }
        */
    }




    /*
        public float MoveSpeed = 5.0f;
        private float horz;
        private float vert;

        private void update()
        {

            horz = Input.GetAxis("Horizontal");
            vert = Input.GetAxis("Vertical");
            this.transform.Translate(Vector3.right * horz * MoveSpeed * Time.deltaTime);
            this.transform.Translate(Vector3.forward * vert * MoveSpeed * Time.deltaTime);


        }
    */


    /*
    float moveHorizontal;
    float moveVertical;

    float movingSpeed = 10;

    void update()
    {

        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        transform.Translate(moveVertical * Time.deltaTime * movingSpeed * Vector3.forward);

        transform.Translate(moveHorizontal * Time.deltaTime * movingSpeed * Vector3.right);

    }

    */




}
