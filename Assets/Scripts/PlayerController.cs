using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] public float maxHealth = 100f;
    [SerializeField] public float currentHealth;
    [SerializeField] public float moveSpeed = 1000f;
    [SerializeField] public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void TakeDamage(float damageNumber)
    {
        currentHealth -= damageNumber;
    }

    public void Death()
    {
        isDead = true;
    }
}
