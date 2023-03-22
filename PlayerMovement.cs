using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    internal float speed;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float sprintSpeed = 10f;

    public Rigidbody2D rb;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(KeyCode.LeftShift))
            speed = moveSpeed + sprintSpeed;
        else
            speed = moveSpeed;
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
