using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody2D rB;

    [Header("Properties")]
    [SerializeField] public float bulletSpeed = 10f;

    private void Update()
    {
        rB.velocity = transform.up * bulletSpeed;

        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
