using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) 
    {
        Debug.Log("BULLET COLLISION TRIGGER col.gameobject.tag = " + col.gameObject.tag);
        if (col.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Goomba")
        {
            Destroy(col.gameObject);
        }
 
    }
}
