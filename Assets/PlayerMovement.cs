using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5;
    Vector3 MoveDirection;
    void Start()
    {
        
    }

    void Update()
    {
        MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Move();
    }

    void Move()
    {
        transform.Translate(MoveDirection * Time.deltaTime * MoveSpeed);
    }
}
