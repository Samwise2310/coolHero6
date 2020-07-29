using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katarina_move : MonoBehaviour
{


    // Declaring Variabals
        // Character GameObject
    public GameObject player;
        // Creating Speed boost
    public float speedBoost = 20f;
        // Holds the Characters Vector3 position
    public Vector3 characterPos;


        // Trying to make the animation work
    float verticalMove = 1f;
        // Animator
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxisRaw("Vertical") * speedBoost;

        // Updates the Characters Position every frame
      characterPos = gameObject.transform.position;

        

        // Checks to see if the user has pressed 'up' or 'w'
        if (Input.GetButton("katUp"))
        {
            // Should be turning the walk cycle on
            animator.SetFloat("Speed2", verticalMove);

            moveKatUp(); // Calls the moveKatUp() function
          //  Debug.Log("Pressed the 'W' key");
        }
        else
        {
            // Should be turning the walk cycle off
            animator.SetFloat("Speed2", 0f);
        }

        // Checks to see if the user has pressed 'down' or 's'
        if (Input.GetButton("katDown"))
        {
            moveKatDown(); // Calles the movekatDown() function
                           //   Debug.Log("Pressed the 'S' key");

            // Should be turning the walk cycle on
            animator.SetFloat("Speed3", 1f);
        }
        else
        {
            // Should be turning the walk cycle off
            animator.SetFloat("Speed3", 0f);
        }



    }

    // Moves Katarina back (positively) in the Z space (Away from the camera)
    // Also checks to see if she has reached her back limit of 130 Z
    void moveKatUp()
    {
        

        if (characterPos.z <= 130f)
        {
            player.transform.Translate(Vector3.forward * speedBoost * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        else
        {
         //   Debug.Log("Reached Z 130 - AKA back max"); // This is printed when the player reaches max
        }
    }

    // Moves Katarina forward (Negativly) in the Z space (Towards the camera)
    // Also checks to see if she has reached her forward limit of 70 Z
    void moveKatDown()
    {
        if (characterPos.z >= 70f)
        {
            player.transform.Translate(Vector3.forward * speedBoost * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        else
        {
         //   Debug.Log("Reached Z 70 - AKA forward max"); // This is printed when the player reaches max
        }
    }



}
