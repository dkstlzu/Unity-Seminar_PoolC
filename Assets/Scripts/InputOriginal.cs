using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputOriginal : MonoBehaviour
{
    public float moveSpeed = 1;
    float horizontal;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jumping");
        }

        if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("P is inserted");
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Horizontal inserted");
            horizontal = Input.GetAxis("Horizontal");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse left");
        }

        if (Input.GetMouseButton(1))
        {
            Debug.Log("Mouse right");
        }

        if (Input.GetMouseButton(2))
        {
            Debug.Log("Mouse middle");
        }


    }

    void Move()
    {
        transform.parent.Translate(new Vector3(horizontal * moveSpeed, 0 ,0));
    }
}
