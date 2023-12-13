using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float finalXSpeed = 0;
    public float speed;
    public float jumpingPower;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    void Start()
    {
        
    }


    void Update()
    {
        // Either -1, 1, or 0 depending on moving left, right or not.
        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal != 0f) 
        {
            // Sync the finalXSpeed to player.velocity.x
            finalXSpeed = rb.velocity.x;

            if (Mathf.Abs(rb.velocity.x) > speed)
            {
                if (Mathf.Abs(rb.velocity.x + horizontal * speed / 10) <= Mathf.Abs(rb.velocity.x))
                {
                    // Psuedo horizontal acceleration. 1/10 increments the finalXSpeed for each loop
                    finalXSpeed += horizontal * speed / 10;
                }
            } else
            {
                // Psuedo horizontal acceleration. 1/10 increments the finalXSpeed for each loop
                finalXSpeed += horizontal * speed / 10;
                // Ternary assignment depending on if finalXSpeed is larger than speed
                finalXSpeed = (Mathf.Abs(finalXSpeed) > speed) ? horizontal * speed : finalXSpeed;
            }

            rb.velocity = new Vector2(finalXSpeed, rb.velocity.y);
        }

        // If jump and is on ground, assign jump power to y velocity component
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        // Basically a jump power scaler. If jump button held longer, jump higher.
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }


    /* Creates a circle at location of groundCheck, of radius 0.4 and checks if the circle overlaps any objects with
    a layer that matches groundLayer.*/
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.4f, groundLayer);
    }

    // Future implementation if we have sprite that changes direction, does nothing ATM.
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
