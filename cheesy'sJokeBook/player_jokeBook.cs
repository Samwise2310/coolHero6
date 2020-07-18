using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_jokeBook : MonoBehaviour
{

    // Declaring Variables
        // Max Health
    public int maxHealth = 100;
        // Current Health
    public int currentHealth = 55;


        // Holding the public value for damageFromTomato
    public int damageFromTomato = 20;
        // Holding the public value for damageFromBomb
    public int damageFromBomb = 20;

        // This is what write the text on the screen
    public Text timerText;
        // This is how long the entire game will last
    public float startTime;

        // Setting the variable t to hold time
    float t;



    public healthBar healthBar;



    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {

        // print("Time = " + t);

        float t2 = startTime - Time.time;
        t = t2;
        if (t >= 0f)
        {
            ifTime();
            //print("In the t if statment");
            //string minutes = ((int)t / 60).ToString();
            //string seconds = (t % 60).ToString("f0");

            //timerText.text = minutes + ":" + seconds;
        }
        if (t2 <= -30f)
        {
            elseTime();
            //print("I am in the t else statment");
            //checkingHealth();
        }



        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        */

    }

    void ifTime()
    {
        // print("In the t if statment");
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;
    }

    void elseTime()
    {
        // print("I am in the t else statment");
        checkingHealth();
    }




    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }




    void OnCollisionEnter(Collision collision)
    {


        // Collision with Tomato
        if (collision.gameObject.tag == "tomato")
        {

            currentHealth -= damageFromTomato;

            healthBar.SetHealth(currentHealth);


           // print("Tomato collided with player. YAY!");

        }


        // Collision with Bomb
        if (collision.gameObject.tag == "Bomb")
        {
            currentHealth += damageFromBomb;

            healthBar.SetHealth(currentHealth);
        }


    }


    void checkingHealth()
    {
        print("Your current Health is " + currentHealth);

        if (currentHealth >= 50)
        {
            print("Health is greater than 50: Health = " + currentHealth);
            SceneManager.LoadScene("cheesyJokeBook_winState");
        }
        else
        {
            print("Health is lower than 50, You SUCK: Health = " + currentHealth);
            SceneManager.LoadScene("cheesyJokeBook_looseState");
        }

    }



}
