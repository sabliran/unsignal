using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TakingDamageCameraScript : MonoBehaviour
{

   public CinemachineVirtualCamera vcam;

    private float timer = 100f;
    private float waitTime = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        
        Debug.Log(transform);
        vcam.m_Lens.FieldOfView = 41f;

    }
   
}
