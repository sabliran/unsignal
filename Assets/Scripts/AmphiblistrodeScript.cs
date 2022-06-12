using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmphiblistrodeScript : MonoBehaviour
{
    // Start is called before the first frame update

    public enemy refScript;
    Animator animator;
    void Start()
    {
         enemy refScript = GetComponent<enemy>();
         animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (refScript.isChasing == true)
        {
            
            animator.SetBool("isMovingAmph", true);
        
            
        }else
        {
            
            animator.SetBool("isMovingAmph", false);
           
        }

        if(refScript.distToPlayer <= 3f)
        {
           
            animator.SetBool("isJumpingAmph", true);

            refScript.jumpSpeed = 2;


        }else
        {
            animator.SetBool("isJumpingAmph", false);
        }




    }
}
