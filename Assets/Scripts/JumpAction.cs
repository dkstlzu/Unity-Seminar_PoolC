using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAction : MonoBehaviour
{
    public float JumpSpeed = 5;
    public GameObject RayCastPosition;
    Rigidbody rb;

    [SerializeField] bool DidDoubleJump = false; 
    [SerializeField] bool StepGround = true;
    [SerializeField] bool AtTop = false;
    bool c = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (StepGround || !DidDoubleJump)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);

                if (!StepGround)
                {
                    DidDoubleJump = true;
                }

                StepGround = false;
            }
        }

        if (c && rb.velocity.y < 0)
        {
            AtTop = true;
            c = false;
        }

        
        // RayCast를 이용해서 체크
        if (AtTop)
        {
            if (Physics.Raycast(RayCastPosition.transform.position, Vector3.down, 0.1f))
            {
                StepGround = true;
                DidDoubleJump = false;
                AtTop = false;
                c= true;
            }
        }

    }
}
