using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Rigidbody rb;
    AudioSource ding;
    MeshRenderer mesh;
    CapsuleCollider col;

    float pitch;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ding = GetComponent<AudioSource>();
        mesh = GetComponent<MeshRenderer>();     
        col = GetComponent<CapsuleCollider>();
    }

    //Hit
    private void OnTriggerEnter(Collider other)
    {
        pitch = ((transform.position.x + 10) / 20) + 1;
        ding.pitch = Mathf.Log(pitch) * 2 + 1;
        ding.Play();
        mesh.enabled = false;
        col.enabled = false;
        Invoke("Destroy", 3);
    }
    //Miss
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.instance.playerLife--;
        GameManager.instance.CheckScore();
        Debug.Log(GameManager.instance.playerLife);
        Invoke("Destroy", 3);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

}
