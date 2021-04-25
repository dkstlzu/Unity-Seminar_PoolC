using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfTest : MonoBehaviour
{
    [Range(0,1)] public float Value;
    private float Result;

    void FixedUpdate()
    {
        Debug.Log(Time.deltaTime);

    }

}
