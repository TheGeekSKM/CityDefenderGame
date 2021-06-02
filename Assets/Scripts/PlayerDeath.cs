using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private bool hasEntered;
    
    ParticleSystem particle;
    
    void Start() 
    {
        particle = GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Alien") && !hasEntered)
        {
            hasEntered = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            StartCoroutine(particleActivate());
            LevelManager.instance.Respawn();
        }
    }
    
    IEnumerator particleActivate()
    {
        yield return new WaitForSeconds(3);
        particle.Play();
    }

}
