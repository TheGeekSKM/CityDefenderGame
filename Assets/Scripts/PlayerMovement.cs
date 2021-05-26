using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody2D rB;
    [SerializeField] PlayerController pC;

    //Private Variables
    Vector2 movement;
    float moveSpeed;

    private void Start()
    {
        moveSpeed = pC.moveSpeed;
    }


    void Update()
    {
        if (transform.position.y < -4.07f)
        {
            transform.position = new Vector3(transform.position.x, -4.07f, transform.position.z);
        }
        if (transform.position.y > -0.89f)
        {
            transform.position = new Vector3(transform.position.x, -0.89f, transform.position.z);
        }

        if (transform.position.x < -8.47f)
        {
            transform.position = new Vector3(-8.47f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 8.47f)
        {
            transform.position = new Vector3(8.47f, transform.position.y, transform.position.z);
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rB.AddForce(movement * moveSpeed * Time.fixedDeltaTime);
    }
}
