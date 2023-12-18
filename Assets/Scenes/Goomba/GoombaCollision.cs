using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("GOOMBA COLLISION TRIGGER col.gameobject.tag = " + col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER HIT!!!");
        }
        else if (col.gameObject.tag == "bubble")
        {
            Destroy(gameObject);
            Debug.Log("GOOMBA HIT");
            Destroy(col.gameObject);
        }

    }
   /* private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bubble")
        {
            Destroy(gameObject);
            Debug.Log("GOOMBA HIT");
            Destroy(col.gameObject);
        }
    } */
}
