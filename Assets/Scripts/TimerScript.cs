using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public float timeRemaining;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            
        }
    }
}
//https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/