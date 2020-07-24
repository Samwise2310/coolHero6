using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{


    //// Declaring Variabals
    //    // Current warp pipe number
    //public int currentPipeNumber;
    //    // holding player reference
    //public GameObject player;
    //    // Array of pipe numbers
    //public GameObject[] warpPipeArray;




    //public static sceneManager instance = null;




    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        DontDestroyOnLoad(gameObject);
    //        instance = this;
    //    }
    //    else if (instance != null)
    //    {
    //        Destroy(instance);
    //    }


    //    if (player == null)
    //        player = GameObject.FindGameObjectWithTag("Player");
    //    if (warpPipeArray.Length == 0)
    //        warpPipeArray = GameObject.FindGameObjectsWithTag("warpPipe");

    //}



    //void OnLevelWasLoaded()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    warpPipeArray = GameObject.FindGameObjectsWithTag("warpPipe");


    //    for (int i = 0; i < warpPipeArray.Length; i++)
    //    {
    //        if (warpPipeArray[i].GetComponent<warpPipe>().warpPipeNumber == currentPipeNumber)
    //        {
    //            player.transform.position = warpPipeArray[i].transform.position;
    //        }
    //    }

    //}



    //public void LoadScene(int passedWarpPipeNumber)
    //{
    //    currentPipeNumber = passedWarpPipeNumber;


    //    if (Application.loadedLevel == 3)
    //    {
    //        Application.LoadLevel("katarinasSearch_scene02");
    //    }
    //    else if (Application.loadedLevel == 4)
    //    {
    //        Application.LoadLevel("katarinasSearch_scene01");
    //    }
    //}







}
