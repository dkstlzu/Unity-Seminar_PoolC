using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(transform.name + " hit " + other.transform.name);
        StartCoroutine(DestroyOneSec());
    }

    IEnumerator DestroyOneSec()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
