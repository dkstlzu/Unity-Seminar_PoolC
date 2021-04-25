using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    public bool pause;
    public bool unpause;
    public bool check = true;
    public bool timecheck;

    void Start()
    {
        check = true;
    }

    void Update()
    {
        if (pause && check) 
        {
            pause = true;
            unpause = false;
            Pause();
            check = false;
        } else if (unpause && check)
        {
            pause = false;
            unpause = true;
            check = false;
            UnPause();
        } else if (!pause && !unpause)
        {
            check = true;
        }

        if (timecheck)
        {
            print(Time.time);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        Time.timeScale = 1;
    }
}
