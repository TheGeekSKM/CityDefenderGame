using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private bool hasEntered;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Alien") && !hasEntered)
        {
            hasEntered = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }
    }
}
