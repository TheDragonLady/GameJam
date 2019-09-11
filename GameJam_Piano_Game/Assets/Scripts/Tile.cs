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

    //hit
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.instance.hit();
    }

    //miss
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.Miss();
    }
}
