using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotater : MonoBehaviour
{
    private Vector2 swipeStartPos;
    private Vector2 swipeEndPos;
    public float rotationSpeed = 100f;


    private void LateUpdate()
    {
        NewSystem();
    }

    void NewSystem()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Moved)
        {
            Vector3 Rotation = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, Rotation.x * rotationSpeed * Time.deltaTime, 0);

        }
    }



    void Keyboard()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}


