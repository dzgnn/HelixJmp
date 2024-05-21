using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ended : MonoBehaviour, ITouch
{

    private bool ended = false;
    public void Collide()
    {
        Debug.Log("değdi");
        
        if (ended == true)
        {
            return;
        }

        ActionManager.NextAction();
        ended = true;

    }
}
