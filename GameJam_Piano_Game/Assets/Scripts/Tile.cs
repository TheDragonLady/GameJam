using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Miss
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.instance.Miss();
    }

    //Hit
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.Hit();
    }
}
