using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody2D rB;

    [Header("Properties")]
    [SerializeField] public float alienSpeed = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rB.MovePosition(rB.position + new Vector2(0, -1) * alienSpeed * Time.fixedDeltaTime);
    }
}
