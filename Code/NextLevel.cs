using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour{

    private int nextScene;
    
    private void Start()
    {
        //Destination for the next scene
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    //function if the character collides
    private void onCollisionrEnter2D(Collider2D collision)
    {
        //Destination for the next scene
        SceneManager.LoadScene(nextScene);
    }
}
