using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    IEnumerator WaitAndPrint()
    {
        print("Before Wait");

        // suspend execution for 5 seconds
        yield return new WaitForSeconds(5);
        print("WaitAndPrint " + Time.time);
    }

    void Start()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        StartCoroutine(WaitAndPrint());
        print("Done " + Time.time);
    }
}