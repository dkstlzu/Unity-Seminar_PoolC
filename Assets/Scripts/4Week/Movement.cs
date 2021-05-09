using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 10;
    public MoveType moveType;
    Vector3 MoveDirection;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
        Move();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            print("forward : " + transform.forward);
            print("right : " + transform.right);
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
            rb.AddForce(MoveDirection * Time.deltaTime * MoveSpeed * 10);
            break;

            case MoveType.AddForceRelative:
            // Using Rigidbody.AddForce
            rb.AddForce((transform.forward * MoveDirection.z * Time.deltaTime * MoveSpeed) * 10 + (transform.right * MoveDirection.x * Time.deltaTime * MoveSpeed) * 10);
            break;

            case MoveType.AddForceAccel:
            // Using Rigidbody.AddForce
            rb.AddForce(MoveDirection, ForceMode.Acceleration);
            break;

            case MoveType.AddForceImpulse:
            // Using Rigidbody.AddForce
            rb.AddForce(MoveDirection, ForceMode.Impulse);
            break;

            case MoveType.AddForceVelocity:
            // Using Rigidbody.AddForce
            rb.AddForce(MoveDirection, ForceMode.VelocityChange);
            break;
        }
    }

    public enum MoveType
    {
        Transform,
        TransformRelative,
        Translate,
        AddForce,
        AddForceRelative,
        AddForceAccel,
        AddForceImpulse,
        AddForceVelocity,
    }
}
