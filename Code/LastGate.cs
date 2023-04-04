using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastGate : MonoBehaviour
{
    //function if the character collides
    private void onCollisionrEnter2D(Collider2D collision)
    {
        //Destination for the next scene
        SceneManager.LoadScene("Menu");
    }
}
