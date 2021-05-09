using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSample : MonoBehaviour
{
    public GameObject Bullet;
    public List<Bullet> FiredBullets;
    public float BulletForce = 10;

    Transform FirePos;


    void Start()
    {
        FirePos = transform.Find("Arm").Find("FirePosition");
        FiredBullets = new List<Bullet>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject FiredBulletObj = Instantiate(Bullet, FirePos.position, FirePos.rotation);
            Rigidbody Bulletrb =  FiredBulletObj.GetComponent<Rigidbody>();
            Bullet FiredBullet = FiredBulletObj.GetComponent<Bullet>();

            Bulletrb.AddForce(FiredBulletObj.transform.forward * BulletForce);

            if (FiredBullet != null)
            {
                FiredBullets.Add(FiredBullet);
            }
        }        
    }
}
