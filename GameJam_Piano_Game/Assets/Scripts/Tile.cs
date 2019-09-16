using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Rigidbody rb;
    AudioSource ding;
    float pitch;
    MeshRenderer mesh;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        ding = GetComponent<AudioSource>();
    }

    //Miss
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        GameManager.instance.playerScore--;
        GameManager.instance.CheckScore();
    }

    //Hit
    private void OnTriggerEnter(Collider other)
    {
        pitch = ((transform.position.x + 10) / 20) + 1;
        ding.pitch = Mathf.Log(pitch)*2 + 1;
        ding.Play();
        mesh.enabled = false;
    }
}
