using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float CameraSpeed = 3;
    Vector3 CamRotaion;
    void Start()
    {
        
    }

    void Update()
    {
        print("X : " + Input.GetAxis("Mouse X"));
        print("Y : " + Input.GetAxis("Mouse Y"));
        CamRotaion = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        print(CamRotaion);
        if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            print("???");
        }
    }

    void FixedUpdate () {
        float x = 5 * Input.GetAxis ("Mouse X");
        float y = 5 * -Input.GetAxis ("Mouse Y");
        Camera.main.transform.Rotate (x, y, 0);
    
    
    }
}
