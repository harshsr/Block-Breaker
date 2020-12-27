using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    int paddleSpeed;
    float leftXBoundary;
    float rightXBoundary;

    void Start()
    {
        paddleSpeed = 25;

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetButton("Horizontal"))
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float currentX = this.gameObject.transform.position.x;
            transform.Translate((Time.deltaTime*paddleSpeed*horizontalInput), 0, 0, Camera.main.transform);
        }
    }
}
