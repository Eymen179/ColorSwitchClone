using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D ball;
    public float bouncePower;
    public AudioSource soundBounce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ball.velocity = Vector2.up * bouncePower;
            soundBounce.Play();
        }
        
    }
}
