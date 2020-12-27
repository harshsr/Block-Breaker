﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] GameObject paddleRef;
    [SerializeField] float ballFloatDistance;
    [SerializeField] float launchSpeedX;
    [SerializeField] float launchSpeedY;

    bool isAttatchedToPaddle;
    float ballX;
    float ballY;

    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        isAttatchedToPaddle = true;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isAttatchedToPaddle==true)
        {
            ballX = paddleRef.transform.position.x;
            ballY = paddleRef.transform.position.y + ballFloatDistance;

            transform.position = new Vector2(ballX, ballY);

            if(Input.GetMouseButtonDown(0))
            {
                LaunchBall();
            }
        }

        else if(isAttatchedToPaddle==false)
        {

        }
    }

    private void LaunchBall()
    {
        isAttatchedToPaddle = false;
        rb2D.velocity = new Vector2(launchSpeedX, launchSpeedY);
    }
}
