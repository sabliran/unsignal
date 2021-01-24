using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TakingDamageCameraScript : MonoBehaviour
{

   public CinemachineVirtualCamera vcam;

  

   

    

        

        
            
    
        
        void OnEnable() 
        {
            playerscript.GotHitCamera += zoom;    
            
        }
        
        void OnDisable()
        {
            playerscript.GotHitCamera -= zoom; 
        }   

    

    void zoom()
    {
        //Camera field of view changing to 41
        vcam.m_Lens.FieldOfView = 80f;
        
    }
    
     void Update() 
    {
        

            vcam.m_Lens.FieldOfView = 81f;
            
        


    }






    
   
}
