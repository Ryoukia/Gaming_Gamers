using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    void OnTriggerEnter2D(Collision2D col) 
    {
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
