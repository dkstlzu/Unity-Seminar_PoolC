using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Vector3 RotationValue;
    void Start()
    {
        
    }

    void Update()
    {
        RotationValue = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);

        Rotate();
    }

    void Rotate()
    {
        // transform.Rotate(new Vector3(-RotationValue.y, RotationValue.x, 0));

        transform.rotation = Quaternion.Euler(transform.eulerAngles + new Vector3(-RotationValue.y, RotationValue.x, 0));
    }
}
