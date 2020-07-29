using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looseWin_timer_penmanship : MonoBehaviour
{


    // Declaring Variabals
    // Timer
    public float timer;
    // Level to load passed through in unity
    public string levelToLoad;




    void FixedUpdate()
    {

        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer < 0)
        {
            Application.LoadLevel(levelToLoad);
        }

    }

}
