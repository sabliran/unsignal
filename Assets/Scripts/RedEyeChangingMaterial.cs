using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEyeChangingMaterial : MonoBehaviour
{
   
    public Material Material1;
    public GameObject Object;
    public enemy refScript;

    
    void Start()
    {
        enemy refScript = GetComponent<enemy>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (refScript.isCloseEnough == true)
        {
            Object.GetComponent<Renderer> ().material = Material1;
        }
        

        

         
        
    }
}
