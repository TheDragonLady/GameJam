using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameManager GM;
    public float PlayerSpeed = 1f;

    private Vector3 playerPos = new Vector3(0, 1.3f, 0);

    public float hitScale = 2.0f;

    Vector3 smallSize;
    Vector3 bigSize;
    public float growthTime = 0.5f;
    public float growthWait = 0.2f;
    public float growthSpeed = 1f;

    BoxCollider collider;

    void Start()
    {
        collider = GetComponent<BoxCollider>();
        smallSize = new Vector3(1f, 0.3f, 0.3f);
        bigSize = new Vector3(2f, 0.6f, 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * PlayerSpeed);
        Debug.Log(Input.GetAxis("Horizontal"));
        playerPos = new Vector3(Mathf.Clamp(xPos, -9.4f, 9.4f), 1.3f, 0f);
        transform.position = playerPos;

        if(Input.GetButtonDown("Fire1"))
        {
            Grow();
            Invoke("Shrink", growthWait);
        }
    }

    public void Grow()
    {
        collider.enabled = true;
        transform.localScale = bigSize;
    }

    public void Shrink()
    {
        collider.enabled = false;
        transform.localScale = smallSize;
    }
}
