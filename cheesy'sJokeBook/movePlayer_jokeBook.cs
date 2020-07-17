using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePlayer_jokeBook : MonoBehaviour
{

   
        float speed = 5;

        // Update is called once per frame
        void Update()
        {
            Vector3 moveDir = Vector3.zero;
            moveDir.x = Input.GetAxis("Horizontal");
            moveDir.z = Input.GetAxis("Vertical");

            transform.position += moveDir * speed * Time.deltaTime;



            // Puase game
            if (Input.GetButtonDown("Pause"))
            {
                SceneManager.LoadScene("LibraryWhitebox");
            }


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
