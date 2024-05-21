using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daire : MonoBehaviour
{
    private Transform player;
    public GameObject[] piece;
    public float explosionForce = 10f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    public void DestroyRing()
    {
        Vector3 explosionDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(0f, 1f), Random.Range(-1f, 1f)).normalized;
        for (int i = 0; i < piece.Length; i++)
        {
            piece[i].GetComponent<Rigidbody>().isKinematic = false;
            piece[i].GetComponent<Rigidbody>().useGravity = true;
            piece[i].GetComponent<Rigidbody>().AddForce(explosionDirection * explosionForce, ForceMode.Impulse);
            Destroy(piece[i].gameObject, 0.3f);
        }
       
        Destroy(this.gameObject, 0.5f);

    }
}
