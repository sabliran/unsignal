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
        


        
            
    
        
        void OnEnable() 
        {
            playerscript.OnClicked += zoom;    
            
        }
        
        void OnDisable()
        {
            playerscript.OnClicked -= zoom; 
        }   

    

    void zoom()
    {
        //Camera field of view changing to 41
        vcam.m_Lens.FieldOfView = 41f;
    }
    






    }
   
}
