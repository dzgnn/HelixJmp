using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowObject : MonoBehaviour
{
    BallControl ballcontrol;

    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 50f;

    void Start()
    {
        ballcontrol = FindObjectOfType<BallControl>();
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        Downer1();
    }

    // public void Downer()
    // {
    //     transform.position += new Vector3(0, -1, 0);
    //     ballcontrol.isPassed = false;
    // }

    public void Downer1()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed);
        transform.position = newPos;
    }

}
