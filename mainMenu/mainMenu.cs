using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainMenu : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene(0);

    }

    public void options()
    {
        

    }
    
    public void exitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }



}
