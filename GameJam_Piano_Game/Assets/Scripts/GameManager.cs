using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int playerScore;
    public int playerLife = 3;

    public GameObject tile;
    public float tileRange;
    public float tileFreq;



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

    }

    public void Setup()
    {
        Instantiate(player, transform.position, Quaternion.identity);
    }

    private void Update()
    {

    }

    public void SpawnTile()
    {
        Instantiate(tile, transform.position, Quaternion.identity);
    }

    public void hit()
    {
        
    }

    public void Miss()
    {

    }
}
