using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Main Menu button functions
public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        //Destination for the next scene
        SceneManager.LoadScene("Scene0");
    }

    public void LevelSelect()
    {
        //Destination for the next scene
        SceneManager.LoadScene("1SceneL");
    }

    public void Credits()
    {
        //Destination for the button pressed
        Application.OpenURL("https://ece.uowm.gr/index.php");
    }

    public void QuitGame()
    {
        //Destination for the next scene
        Application.Quit();
    }
}