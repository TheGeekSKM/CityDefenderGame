using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    [Header("Properties")]
    [SerializeField] public string shipType = "Crasher";
    [SerializeField] public float health = 20;
    void Update()
    {
        if (health <= 0f)
        {
            Die();
        }
    }

    public void BulletDamage()
    {
        health -= 10f;
    }
    public void BulletDamage(float damageNumber)
    {
        health -= damageNumber;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
