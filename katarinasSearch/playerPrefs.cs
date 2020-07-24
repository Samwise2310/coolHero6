using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefs : MonoBehaviour
{

    public float position_x = 110.5f;
    public float position_y = -20.3f;
    public float position_z = 100f;


    void start()
    {
        PlayerPrefs.GetFloat("positionX");
        PlayerPrefs.GetFloat("positionY");
        PlayerPrefs.GetFloat("positionZ");
    }



    public void positionFunction()
    {
        Debug.Log("In the position Function");


        PlayerPrefs.SetFloat("positionX", position_x);
        PlayerPrefs.SetFloat("positionY", position_y);
        PlayerPrefs.SetFloat("positionZ", position_z);

    }









}
