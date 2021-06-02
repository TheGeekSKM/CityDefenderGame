using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetector : MonoBehaviour
{
    [Header("References")]
    [SerializeField] EnemyController eC;


    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Bullet"))
    //    {
    //        eC.BulletDamage(10f);
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            eC.BulletDamage(10f);
            Destroy(collision.gameObject);
            LevelManager.instance.AddAliensKilled();
        }

        
    }
}
