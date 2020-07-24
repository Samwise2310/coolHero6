using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneSwitch_manager02 : MonoBehaviour
{

    //// Declaring Variabals
    //    // levelToLoad holds the level you are going too
    //public string levelToLoad;
    //    // Player Game Object holds a reference to the player
    //public GameObject player;
    //    // Current Scene will hold which scene I am in currently
    //public string currentScene;
    //    // Respawn location from scene 2 back to scene 1
    //public Vector3 respawnLocation_scene2_scene1;
    //    // Respawn location from scene 3 back to scene 2
    //public Vector3 respawnLocation_scene3_scene2;
    //    // Respawn location from scene 4 back to scene 3
    //public Vector3 respawnLocation_scene4_scene3;



    //public static sceneSwitch_manager02 instance = null;



    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        DontDestroyOnLoad(gameObject);
    //        instance = this;
    //    }
    //    else if (instance != null)
    //    {
    //        Destroy(gameObject);
    //    }

    //    if (player == null)
    //        player = GameObject.FindGameObjectWithTag("Player");
    //}



    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        movingPlayerToRespawnPoint();

    //    //    Application.LoadLevel(levelToLoad);
    //    }
    //}



    //void movingPlayerToRespawnPoint()
    //{
    //    if (currentScene == "katarinasSearch_scene02")
    //    {
    //        if (levelToLoad == "katarinasSearch_scene01")
    //        {
    //            Debug.Log("In Scene 2 - Going back to Scene 1");
    //            Application.LoadLevel(levelToLoad);
    //            player.transform.position = respawnLocation_scene2_scene1;
    //        }
    //    }
    //    else if (currentScene == "katarinasSearch_scene03")
    //    {
    //        if (levelToLoad == "katarinasSearch_scene02")
    //        {
    //            Debug.Log("In Scene 3 - Going back to Scene 2");
    //            Application.LoadLevel(levelToLoad);
    //            player.transform.position = respawnLocation_scene3_scene2;
    //        }
    //    }
    //    else if (currentScene == "katarinasSearch_scene04")
    //    {
    //        if (levelToLoad == "katarinasSearch_scene03")
    //        {
    //            Debug.Log("In Scene 4 - Going back to Scene 3");
    //            Application.LoadLevel(levelToLoad);
    //            player.transform.position = respawnLocation_scene4_scene3;
    //        }
    //    }
    //}






}



// if current level 2
// if level to load 3
// if level to laod 1
