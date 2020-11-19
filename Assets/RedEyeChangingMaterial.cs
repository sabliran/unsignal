using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEyeChangingMaterial : MonoBehaviour
{
   
    public Material Material1;
    public GameObject Object;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Object.GetComponent<Renderer> ().material = Material1;

        

         
        
    }
}
