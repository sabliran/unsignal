using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Experimental.Rendering.LWRP;
public class enemy : MonoBehaviour
{
   
     private Transform player;
    

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;
    public GameObject getBullet;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    [SerializeField] GameObject laserPrefab;
    
     public Transform Screentip;
    
     private float nextShootTime;
     
    
    [SerializeField] float projectileSpeed;
    public UnityEngine.Experimental.Rendering.Universal.Light2D changeColor;
    
     Rigidbody2D rb2d;
    
    private bool gotHit;
    public bool isCloseEnough;
    public float destroyLaser;

   
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        rb2d = GetComponent<Rigidbody2D>();
        //changeColor = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
        player = GameObject.FindWithTag("Player").transform;
        
    }

     void OnCollisionEnter2D(Collision2D col)

    {
        getBullet = GameObject.FindWithTag("enemyLaser");

        if (col.collider.tag == "bullet")
        {
            Destroy(getBullet, 0.3f);

            TakeDamage(20);

            gotHit = true;
        }


        // if (col.collider.tag == "Aura")
        // {
            

        //     TakeDamage(20);

        //     gotHit = true;
        // }

    }

     void OnTriggerStay2D(Collider2D collision)
        {
        if (collision.gameObject.tag == "Aura")
        {  
            
            
            TakeDamage(1);

            gotHit = true;
            
        }
        }

     private void Update()
    {        
        
        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position); 

        if (distToPlayer <= agroRange)
        {
            
            //code to chase player
            ChasePlayer();

            fire();  
            isCloseEnough = true;

    
        }
        else 
        {
            gotHit = false;
            //stop chasing player
            StopChasingPlayer();
            changeColor.intensity= 1f;
            changeColor.color = new Color(0,3,4,0);
            changeColor.pointLightOuterRadius = 2;
            
        }

        if( gotHit == true)
        {
            ChasePlayer();

            fire();
        }

    
        if (currentHealth == 0)
        {
            Destroy(this.gameObject);
        }

    }

     void ChasePlayer()
    {       //change color
            changeColor.color = new Color(4,2,0,0);
            changeColor.pointLightOuterRadius = 7;
           

        if (transform.position.x < player.position.x)
        {   //move to the right
            rb2d.velocity = new Vector2(moveSpeed, 0);
            // MUCH BETTER WAY TO FLIP AN OBJECT. flipX is not a good practice.
            transform.localScale = new Vector2(1, 1);
            projectileSpeed = 10;

        }
        else 
        {  //move to the left
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);
            projectileSpeed = -10;
        }
    
    }

     void StopChasingPlayer()
    {
            rb2d.velocity = new Vector2(0, 0);
            
            
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void fire()
    {
            if (Time.time > nextShootTime)
            {

            
            //Instantiate Bullet
            GameObject laser = Instantiate(laserPrefab, Screentip.position, Quaternion.identity) as GameObject;
            //Speed of the Bullet
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);
            float fireRate = .1f;
            nextShootTime = Time.time + fireRate;
            
                // Destroy(laserPrefab);               
                // Debug.Log(bulletDecay);
            //GameObject.Destroy(laserPrefab , 1f);
            Destroy (laser, destroyLaser);
            

            }
    }




 
            
            
        
    


}

