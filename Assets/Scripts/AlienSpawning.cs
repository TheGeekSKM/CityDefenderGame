using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class AlienSpawning : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject alienSpaceShip;

    [Header("Properties")]
    [SerializeField] public float timeBetweenWaves = 3f;

    //private
    private float timeToSpawn = 2f;

    
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnShips();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnShips()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(alienSpaceShip, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }

    //I am making a change!!!
}
