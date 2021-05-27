using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSample2 : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePosition;
    public Vector3 FireDirection;
    public float FireForce;


    void Start()
    {
        if (FirePosition == null)
        {
            FirePosition = transform.Find("FirePosition");
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        // 1 Bullet을 Instantiate 해준다
        GameObject bullet = Instantiate<GameObject>(Bullet, FirePosition.position, Quaternion.identity);
        // 2 Bullet에 속도를 넣어준다.
        Rigidbody rbSample;
        if (!bullet.TryGetComponent<Rigidbody>(out rbSample))
        {
            rbSample = bullet.AddComponent<Rigidbody>();
        }

        // Rigidbody rb = bullet.GetComponent<Rigidbody>();
        
        // rb.AddForce(FireForce, ForceMode.Impulse);
        rbSample.AddForce(transform.forward * FireForce, ForceMode.Impulse);
    }
}
