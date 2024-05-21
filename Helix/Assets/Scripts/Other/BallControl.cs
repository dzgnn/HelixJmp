using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    public float bounce = 120;
    FollowObject followObject;
    Rigidbody rigi;
    Daire daire;
    GameManager gameManager;
    LevelManager levelManager;
    UIManager uiManager;





    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        followObject = FindObjectOfType<FollowObject>();
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter(Collision othercollision)
    {
        rigi.velocity = new Vector3(rigi.velocity.x, bounce * Time.deltaTime, rigi.velocity.z);
        othercollision.gameObject.GetComponent<ITouch>()?.Collide();
    }


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<IPassed>()?.Triged();
    }

}