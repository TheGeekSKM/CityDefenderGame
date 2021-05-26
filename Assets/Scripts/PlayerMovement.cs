using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody2D rB;

    [Header("Properties")]
    [SerializeField] public float moveSpeed = 1000f;
    [SerializeField] public float turnSpeed = 10f;

    //Private Variables
    Vector2 movement;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rB.AddForce(movement * moveSpeed * Time.fixedDeltaTime);
    }
}
