using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_jokeBook : MonoBehaviour
{


    // Declaring Variables
        // Max Health
    public int maxHealth = 100;
        // Current Health
    public int currentHealth;


        // Holding the public value for damageFromTomato
    public int damageFromTomato = 20;
        // Holding the public value for damageFromBomb
    public int damageFromBomb = 20;



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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        
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


}
