using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ballPosition;
    public Transform groundPosition;
    void Update()
    {
        if(ballPosition.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ballPosition.position.y, transform.position.z);
            //groundPosition.position = new Vector3(transform.position.x,ballPosition.position.y, transform.position.z);
        }
    }
}
