﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescriptCHALLENGE : MonoBehaviour
{

    void Update()
    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time), Mathf.Sin(Time.time), Mathf.Sin(Time.time));
 
         transform.localScale = vec;
        
    }
}
