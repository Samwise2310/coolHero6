using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDamage : MonoBehaviour
{

    /*
     * This script is checking to see if the players health ever
     * drops below 0
     * If the players health ever does get to below 0 then it calls
     * the Die() function
     *      the Die() function will bring up the penmanship_looseScene
     */


    // Declaring Variabals
        // Health holds the players max health
    public float health = 100f;



    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }


    void Die()
    {
        Application.LoadLevel("penmanship_looseState");
    }

}
