using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst : MonoBehaviour, IPassed
{

    public void Triged()
    {
        gameObject.GetComponent<Daire>().DestroyRing();
        UIManager.instance.AddPoint();
    }
}
