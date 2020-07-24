using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour
{

    // Declaring Variabals
        // levelToLoad holds the level you are going too
    public string levelToLoad;
        


    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Application.LoadLevel(levelToLoad);
        //    Debug.Log("HIT");
        }
    }
}
