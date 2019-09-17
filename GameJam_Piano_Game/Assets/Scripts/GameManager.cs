using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int playerScore;
    public int playerLife = 3;
    public float playerHeight = 0.5f;

    public GameObject tile;
    public float tileRange;
    public float tileHeight = 10f;
    public float tileFreq;

    public int score = 0;

    public GameObject destroyTrigger;

    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        Setup();
    }

    private void Start()
    {
        InvokeRepeating("SpawnTile", 0, tileFreq);
    }

    public void Setup()
    {
        Instantiate(player, new Vector3(transform.position.x, playerHeight, transform.position.z), Quaternion.identity);
    }

    public void SpawnTile()
    {
        float x = Random.Range(-tileRange, tileRange);
        Instantiate(tile, new Vector3(x, tileHeight, transform.position.z), rotation: Quaternion.Euler(90f, transform.rotation.y, transform.rotation.z));
    }

    public void CheckScore()
    {
        if(playerLife < 1)
        {
            GameOver();
            Invoke("Reset", 3);
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0.25f;
    }

    public void GameWon()
    {
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
