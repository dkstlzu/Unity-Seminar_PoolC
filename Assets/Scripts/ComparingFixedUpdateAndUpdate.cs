using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparingFixedUpdateAndUpdate : MonoBehaviour
{
    public bool DoFixedUpdate;
    public bool UpdateWithDeltaTime;
    public bool DoCompare;

    public static int FixedUpdatesBetweenUpdate = 0;
    public static int UpdatesBetweenFixedUpdate = 0;

    void Start()
    {
        StartCoroutine(Velocity());
    }
    void FixedUpdate()
    {
        if (DoFixedUpdate)
        {
            transform.Translate(Vector3.forward);
            if (DoCompare)
                CountUpdate();
        }
        
        FixedUpdatesBetweenUpdate++;
    }

    void Update()
    {
        if (!DoFixedUpdate)
        {
            if (UpdateWithDeltaTime)
                transform.Translate(Vector3.forward * Time.deltaTime);
            else
                transform.Translate(Vector3.forward);

            if (DoCompare)
                CountFixedUpdate();
        }

        UpdatesBetweenFixedUpdate++;
    }

    private void CountFixedUpdate()
    {
        Debug.Log("Number of FixedUpdate between Updates : " + FixedUpdatesBetweenUpdate);
        FixedUpdatesBetweenUpdate = 0;
    }

    private void CountUpdate()
    {
        Debug.Log("Number of Updates between FixedUpdates : " + UpdatesBetweenFixedUpdate);
        UpdatesBetweenFixedUpdate = 0;
    }

    IEnumerator Velocity()
    {
        float previousPos = transform.position.z;
        float previousTime;

        float deltaPos;
        float deltaTime;

        while (true)
        {
            previousTime = Time.time;
            previousPos = transform.position.z;

            yield return new WaitForSeconds(1f);

            deltaPos = transform.position.z - previousPos;
            deltaTime = Time.time - previousTime;

            Debug.LogFormat("Velocity Check : {0}", deltaPos/deltaTime);
        }
    }
}
