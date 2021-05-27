using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCoroutine : MonoBehaviour
{
    public int DestroyingTime;
    IEnumerator coroutine;
    void OnCollisionEnter(Collision other)
    {
        coroutine = BulletDestroy(DestroyingTime);
        StartCoroutine(coroutine);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            StopCoroutine(coroutine);
        }
    }

    IEnumerator BulletDestroy(int time)
    {
        for (int i =0; i< time; i++ )
        {
            yield return new WaitForSeconds(1f);
            print((i+1) + " Seconds");
        }
        
        Destroy(gameObject);
    }
}
