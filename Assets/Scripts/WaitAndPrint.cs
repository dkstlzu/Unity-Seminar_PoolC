using UnityEngine;
using System.Collections;

namespace asdf
{
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
            print("Starting " + Time.time); // 1

            // Start function WaitAndPrint as a coroutine
            StartCoroutine("WaitAndPrint"); // 3
            print("Done " + Time.time); // 2
        }
    }
}