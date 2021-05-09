using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 10;
    public MoveType moveType;
    Vector3 MoveDirection;
    Rigidbody rb;
    CharacterController controller;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = gameObject.AddComponent<CharacterController>();
        controller.center = new Vector3(0, 1, 0);
        controller.enabled = false;
    }
    void Update()
    {
        MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        Move();

        if (moveType == MoveType.CharacterController)
        {
            controller.enabled = true;
        } else
        {
            controller.enabled = false;
        }
    }

    void Move()
    {
        switch(moveType)
        {
            case MoveType.Transform:
            // Using transform.position
            transform.position = transform.position + MoveDirection * Time.deltaTime * MoveSpeed;
            break;

            case MoveType.TransformRelative:
            // Using transform.position
            transform.position = transform.position + (transform.forward * MoveDirection.z * Time.deltaTime * MoveSpeed) + (transform.right * MoveDirection.x * Time.deltaTime * MoveSpeed);
            break;

            case MoveType.Translate:
            // Using Translate
            transform.Translate(MoveDirection * Time.deltaTime * MoveSpeed);
            break;

            case MoveType.AddForce:
            // Using Rigidbody.AddForce
            rb.AddForce(MoveDirection * Time.deltaTime * MoveSpeed);
            break;
            case MoveType
            .CharacterController:
            // Using CharacterController.Move
            controller.Move(MoveDirection * Time.deltaTime * MoveSpeed);
            break;
        }
    }

    public enum MoveType
    {
        Transform,
        TransformRelative,
        Translate,
        AddForce,
        CharacterController,
    }
}
