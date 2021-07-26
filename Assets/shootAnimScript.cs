using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAnimScript : MonoBehaviour
{
    
    Animator animator;
    void Start()
    {
        
    }

    
    void Update()
    {
        animator.SetBool("isShooting", true);
        
    }
}
