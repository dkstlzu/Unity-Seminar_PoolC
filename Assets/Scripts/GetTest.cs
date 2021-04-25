using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTest : MonoBehaviour
{
    BoxCollider collider;
    Transform transform;
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }
}
