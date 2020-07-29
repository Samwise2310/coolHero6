using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{

    /*
     * This script is checking to see if the Enemy's health is 
     * less than 0
     * If the Enemy's health ever goes below 0 then it calls the 
     * Die() function
     *      the Die() function will bring up the penmanship_winState scene
     */


    public int health = 100;

    public healthBar_penmanship heathBar;


    public void TakeDamage (int amount)
    {
        health -= amount;

        heathBar.SetHealth(health);

        if (health <= 0f)
        {
            Die();
        }
    }

    
    void Die()
    {
        Application.LoadLevel("penmanship_winState");
    }

}
