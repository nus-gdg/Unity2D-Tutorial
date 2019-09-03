using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    public KeyCode upButton = KeyCode.W;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;
    public float movementSpeed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool upHeld = Input.GetKey(upButton);
        bool leftHeld = Input.GetKey(leftButton);
        bool downHeld = Input.GetKey(downButton);
        bool rightHeld = Input.GetKey(rightButton);

        bool upTapped = Input.GetKeyDown(upButton);
        bool leftTapped = Input.GetKeyDown(leftButton);
        bool downTapped = Input.GetKeyDown(downButton);
        bool rightTapped = Input.GetKeyDown(rightButton);

        //Normal movement
        if (upHeld && leftHeld)
        {
            rb.velocity = new Vector2(-movementSpeed, movementSpeed);
        }
        else if (upHeld && rightHeld)
        {
            rb.velocity = new Vector2(movementSpeed, movementSpeed);
        }
        else if (upHeld && !downHeld)
        {
            rb.velocity = new Vector2(0f, movementSpeed);
        }
        else if (downHeld && leftHeld)
        {
            rb.velocity = new Vector2(-movementSpeed, -movementSpeed);
        }
        else if (downHeld && rightHeld)
        {
            rb.velocity = new Vector2(movementSpeed, -movementSpeed);
        }
        else if (downHeld && !upHeld)
        {
            rb.velocity = new Vector2(0f, -movementSpeed);
        }
        else if (leftHeld && !rightHeld)
        {
            rb.velocity = new Vector2(-movementSpeed, 0f);
        }
        else if (rightHeld && !leftHeld)
        {
            rb.velocity = new Vector2(movementSpeed, 0f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
