using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITouch
{
    public void Collide()
    {
        ActionManager.DeadAction();
    }
}
