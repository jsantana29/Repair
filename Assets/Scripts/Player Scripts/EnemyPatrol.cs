using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // float variables
    public float moveSpeed;
    public float wallCheckRadius;

    // boolean variables
    public bool moveRight;
    private bool hittingWall;

    // Transform variables
    public Transform wallCheck;

    // LayerMask variables
    public LayerMask whatIsWall;

    // Use for initialization
    void Start()
    {

    }

    void Update()
    {
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        // Checks if the player is gonna hit a wall
        if (hittingWall)
        {
            moveRight = !moveRight;
        }
        
        // Checks if the player is moving left or right
        if (moveRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

    }

}

