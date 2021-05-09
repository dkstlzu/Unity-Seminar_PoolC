using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float CameraSpeed = 3;
    public RotateType rotateType;
    Vector3 CamRotaion;
    void Start()
    {
        
    }

    void Update()
    {
        CamRotaion = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));


        Rotate();
    }


    void Rotate()
    {
        Vector3 vec = new Vector3(-CamRotaion.y, CamRotaion.x, 0) * CameraSpeed;
        switch(rotateType)
        {
            case RotateType.Rotate:
            transform.Rotate(vec);
            break;

            
            case RotateType.EulerAngles:
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + vec);
            break;
        }
    }

    public enum RotateType
    {
        Rotate,
        EulerAngles,

    }
}
