using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int health = 1;

    public CharacterController2D controller;

    public float speed = 40f;
   

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    private void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    //kills this unit
    void Hurt()
    {
        health--;
        if (health <= 0)
            Application.LoadLevel(Application.loadedLevel);
    }
    //function if the character collides
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //function if the character collides with an enemy unit
        March march = collision.collider.GetComponent<March>();
        if(march != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                //checks collision point
                if (point.normal.y >= 0.9f)
                {
                   //kills enemy unit
                    march.Hurt();
                }
                else
                {
                    //kills character
                    Hurt();
                }
            }

        }

        //function if the character collides with an enemy unit
        Hunter hunter = collision.collider.GetComponent<Hunter>();
        if (hunter != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                //checks collision point
                if (point.normal.y >= 0.9f)
                {
                    //kills enemy unit
                    hunter.Hurt();
                }
                else
                {
                    //kills character
                    Hurt();
                }
            }

        }

        //function if the character collides with an enemy unit
        Abyss abyss = collision.collider.GetComponent<Abyss>();
        if (abyss != null)
        {
            //kills character
            Hurt();  
        }

        //function if the character collides with an enemy unit
        Patrol patrol = collision.collider.GetComponent<Patrol>();
        if (patrol != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                //checks collision point
                if (point.normal.y >= 0.9f)
                {
                    //kills enemy unit
                    patrol.Hurt();
                }
                else
                {
                    //kills character
                    Hurt();
                }
            }
        }

        //function if the character collides with a gate
        NextLevel gate = collision.collider.GetComponent<NextLevel>();
        if (gate != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                if (point.normal.x >= 0.9f)
                {
                   
                }
                else
                {
                    int SceneN = SceneManager.GetActiveScene().buildIndex;
                    //Destination for the next scene
                    SceneManager.LoadScene(SceneN + 1);
                }
            }   

        }

        //function if the character collides with a gate
        LastGate lgate = collision.collider.GetComponent<LastGate>();
        if (lgate != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                if (point.normal.x >= 0.9f)
                {

                }
                else
                {
                    int SceneN = SceneManager.GetActiveScene().buildIndex;
                    //Destination for the next scene
                    SceneManager.LoadScene("Menu");
                }
            }

        }
    }
}