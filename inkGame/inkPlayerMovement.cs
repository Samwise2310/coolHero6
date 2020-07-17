using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inkPlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal");
        moveDir.z = Input.GetAxis("Vertical");
        moveDir.y = Input.GetAxis("Jump");

        transform.position += moveDir * playerSpeed * Time.deltaTime;



        // Puase game
        if (Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene("LibraryWhitebox");
        }


    }
}
