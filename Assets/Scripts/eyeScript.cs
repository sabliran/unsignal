using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeScript : MonoBehaviour
{

    public float agroRange;
    private Transform player;

    public Rigidbody2D rb2d;
    public float moveSpeed;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position); 

        if (distToPlayer <= agroRange)
        {
            
            //code to chase player
            ChasePlayer();


             
    
        }
        
        

    }

    void ChasePlayer()
    {       

        if (transform.position.x < player.position.x)
        {   //move to the right
            rb2d.velocity = new Vector2(moveSpeed, 0);
            // MUCH BETTER WAY TO FLIP AN OBJECT. flipX is not a good practice.
            transform.localScale = new Vector2(1, 1);
           

        }
        else 
        {  //move to the left
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);
            
        }
    
    }
}
