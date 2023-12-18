using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Goomba_Movement : MonoBehaviour
{

    public float moveSpeed;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((timer % 10) >= 5)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
        }
        
        timer += Time.deltaTime;
    }
}
