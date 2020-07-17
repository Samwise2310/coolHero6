using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;



    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;
    bool crouch = false;


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
            SceneManager.LoadScene("LibraryWhitebox");
        }



    }


    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }


    // Fixed update only updates a certain number of times per second and not every frame like normal Update()
    void FixedUpdate ()
    {

        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

        //rb.velocity = new Vector2(horizontalMove, rb.velocity.y);


    }



}
