using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{

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
        Destroy(gameObject);
    }

}
