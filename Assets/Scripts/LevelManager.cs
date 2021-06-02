using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //make the LevelManager accessible everywhere
    public static LevelManager instance;

    [Header("References")]
    [SerializeField] public Transform respawnPoint;
    [SerializeField] GameObject playerPrefab;

    [Header("Properties")]
    [SerializeField] public float aliensKilled = 0f;
    [SerializeField] public float playerLivesLeft = 3f;


    void Awake()
    {
        //All this does is make the LevelManager accessible in every script in the game without having to keep connecting references
        //over and over again.
        instance = this;
    }

    private void Update()
    {
        //Debug.Log("Aliens killed: " + aliensKilled);
        Debug.Log("Lives Left: " + playerLivesLeft);
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }

    public void Respawn()
    {
        playerLivesLeft--;

        if (playerLivesLeft <= 0f)
        {
            GameOver();
        }

        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        
    }

    public void AddAliensKilled()
    {
        aliensKilled++;
    }

    public void AddAliensKilled(float num)
    {
        aliensKilled += num;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
