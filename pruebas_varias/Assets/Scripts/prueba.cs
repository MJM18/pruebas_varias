using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public float moveSpeed = 4f;

    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        //Movement
        if (movement.x != 0)
        {
            rb.MovePosition(rb.position + new Vector2(movement.x, 0) * moveSpeed * Time.fixedDeltaTime);
        }

    }
}
