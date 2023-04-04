using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Hunter hunts the player while flying
public class Hunter : MonoBehaviour
{
    //kills this unit
    public void Hurt()
    {
        Destroy(this.gameObject);
    }
}
