using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{



    // Declaring Variables
        // Slider will hold the slider passed through in Unity
    public Slider slider;




    public void SetMaxHealth(int health)
    {

        slider.maxValue = health;
        slider.value = health;

    }

    public void SetHealth(int health)
    {

        slider.value = health;

    }


}
