using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{


    // Declaring Variables
    public CharacterController2D controller;
    public Animator animator;



    float horizontalMove = 1f;

    public float runSpeed = 40f;

    bool jump = false;
    bool crouch = false;


        // Vertical Move (Creates the illusion she is moving further away from the camera
    float vertical = 0f;



    // Creating Rigid Body ref for scene switch
   // private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Moving Katarina left/right
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Chaging from Idle animation to walking animation
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        // Making Katarina Jump
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }



        // Making Katarina Crouch
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }


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



        //// Making Katarina Move closer and further from the camera
        //if (Input.GetButtonDown("Vertical"))
        //{
        //    verticalMove();
        //    Debug.Log("W or S Pressed");
        //}

        //void verticalMove()
        //{
        //    vertical = Input.GetAxisRaw("Vertical") * runSpeed;
        //}





    }


    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }


    public void arrowShot()
    {
        animator.SetBool("arrowShot", true);
        Invoke("afterArrowShot", .5f);
    }

    public void afterArrowShot()
    {
        animator.SetBool("arrowShot", false);
    }

    public void rockBowShot()
    {
        animator.SetBool("rockBowShot", true);
        Invoke("rockBowShotOff", .5f);
    }
    private void rockBowShotOff()
    {
        animator.SetBool("rockBowShot", false);
    }



    // Fixed update only updates a certain number of times per second and not every frame like normal Update()
    void FixedUpdate ()
    {

        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;


        controller.Move(vertical * Time.fixedDeltaTime, crouch, jump);

        //rb.velocity = new Vector2(horizontalMove, rb.velocity.y);


    }



}
