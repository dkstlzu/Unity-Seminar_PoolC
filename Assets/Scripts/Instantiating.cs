using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiating : MonoBehaviour
{
    public GameObject obj;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            MakeInstance();
        }
    }

    void MakeInstance()
    {
        obj = Instantiate(obj, ((GameObject)obj).transform.position + new Vector3(0, 3, 0), Quaternion.identity);
    }
}
