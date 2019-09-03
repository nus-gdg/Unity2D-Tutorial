using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }

        bool input = false;

        if(Input.GetKey(right))
        {
            //rb.AddForce(Vector2.right, ForceMode2D.Impulse);
            rb.velocity = new Vector2(5, rb.velocity.y);
            input = true;
        }
        else if(Input.GetKey(left))
        {
            //rb.AddForce(Vector2.left, ForceMode2D.Impulse);
            rb.velocity = new Vector2(-5, rb.velocity.y);
            input = true;
        }

        if(!input)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}