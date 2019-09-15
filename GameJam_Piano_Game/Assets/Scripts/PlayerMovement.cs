using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 1f;

    private Vector3 playerPos = new Vector3(0, 1.3f, 0);

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * PlayerSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -9.4f, 9.4f), 1.3f, 0f);
        transform.position = playerPos;
    }
}
