using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//march moves from right to the left 
public class March : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    //kills this unit
    public void Hurt()
    {
        Destroy(this.gameObject);
    }
}
