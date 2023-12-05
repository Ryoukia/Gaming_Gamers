using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveChar : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    private KeyCode lastHitKey;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, jumpHeight);
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            if (lastHitKey == KeyCode.D)
            {

            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
                lastHitKey = KeyCode.D;
            }
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            if (lastHitKey == KeyCode.A)
            {

            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2((-1 * moveSpeed), 0);
                lastHitKey = KeyCode.A;
            }
        }
    }
}