using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Levels Menu button functions
public class LevelsMenu : MonoBehaviour
{
    public void Level1()
    {
        //Destination for the next scene
        SceneManager.LoadScene("Scene0");
    }

    public void Leve2()
    {
        //Destination for the next scene
        SceneManager.LoadScene("Scene1");
    }

    public void Leve3()
    {
        //Destination for the next scene
        SceneManager.LoadScene("Scene2");
    }

    public void MainMenu()
    {
        //Destination for the next scene
        SceneManager.LoadScene("Menu");
    }
}