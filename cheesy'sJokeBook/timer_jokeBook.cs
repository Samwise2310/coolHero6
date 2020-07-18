using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer_jokeBook : player_jokeBook
{

    public Text timerText;

    public float startTime;

    


    // Start is called before the first frame update
    void Start()
    {
        // startTime = 29;
        
    }

    // Update is called once per frame
    void Update()
    {


        
            float t = startTime - Time.time;
        if (t >= 0)
        {
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f0");

            timerText.text = minutes + ":" + seconds;
        }
        else
        {
            checkingHealth();
        }
       
    }

    void checkingHealth()
    {

        if (currentHealth >= 50)
        {
            print("Health is greater than 50: Health = " + currentHealth);
        }
        else
        {
            print("Health is lower than 50, You SUCK: Health = " + currentHealth);
        }
        
    }





}
