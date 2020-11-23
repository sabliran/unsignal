using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Threading;
using TMPro;



[RequireComponent(typeof(Rigidbody))]


/*ALGORITHMS AS ANEMIES */

//[TODOS]

//2 rigidbodies
//fix the flip fire function with (brackeys 2D shoooting in unity video) 
//---------------------------------------------------------------------------------
//[POLISHING UP]
//fix where the signalvore have the lazers comming out of
//gravity
//fix the up button *not to fly
//delete the bullet instances after some time
public class playerscript : MonoBehaviour

{

    
              
    public delegate void ClickAction();
    public static event ClickAction GotHitCamera;
    


    private const bool V = true;
    public Transform Screentip;
    public Rigidbody2D rb;
    public float speed;
    private float moveInput;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    public float JumpForce;
    private int extraJumps;
    public int extraJumpsValue;
    [SerializeField] GameObject AuraPrefab;
    [SerializeField] float projectileSpeed;
    private bool faceRight;
    private float bulletDecay = 2;
    [SerializeField] bool damaged;
    public int maxHealth = 1000;
    public int currentHealth;
    public HealthBar healthBar;
    public float countdown = 1.0f;
    public GameObject pointLight;

    public TextMeshProUGUI healthNumbers;
    public GameObject laserPrefab;
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    // FixedUpdate is used to manipulate all physics related aspects
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F7))
        {
            restoreTest(1000);
        }
        
        //Debug.Log(feetPos.position.y)
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }   

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * JumpForce;
            extraJumps --;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * JumpForce;
        }
        
        if (damaged == true)
        {
            
            if(GotHitCamera != null)
                GotHitCamera();

            countdown -= Time.deltaTime;
            if (countdown <= 0.0f)
            {
                TakeDamage(10);
            }
        }
        else
        {
            damaged = false;
        }

        //Horizontal Axis (MOVE LEFT - RIGHT)
        float moveHorizontal = Input.GetAxis("Horizontal");

        //---------test for faceRight bool-----------
        if (moveHorizontal > 0 && faceRight)
        {
            flip();
            //projectileSpeed = 50;
        }
        else if (moveHorizontal < 0 && !faceRight)
        {    
            flip();
            //projectileSpeed = -50;
        }
        Fire();
        Math.Round(bulletDecay);

        healthNumbers.text = currentHealth.ToString();    


    }
        void flip()
    {
        faceRight = !faceRight;
        transform.Rotate(0f, 180f, 0f);
    }    

    void Fire()
    {
        //------------------Aura
       if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate Bullet
            GameObject AuraShoot = Instantiate(AuraPrefab, Screentip.position, Quaternion.identity) as GameObject;
            //Speed of the Bullet
            AuraShoot.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);

                // Destroy(laser);               
                // Debug.Log(bulletDecay);
                Destroy (AuraShoot, 10f);
        }

        //---------------------Laser
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate Bullet
            GameObject laser = Instantiate(laserPrefab, Screentip.position, Screentip.rotation);
            Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
            rb.AddForce(Screentip.right * projectileSpeed, ForceMode2D.Impulse);

            //laser.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);

                // Destroy(laser);               
                // Debug.Log(bulletDecay);
                Destroy (laser, 0.3f);
        }
        
    }
    //Collision detection
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "bullet")
        {
            Debug.Log("bullleplayerr");
        }
        
        if (col.gameObject.tag == "enemy")
        {
            damaged = true;
            Debug.Log("hit");
        }
        
        if (col.gameObject.tag == "enemyLaser")
        {
            damaged = true;
            Debug.Log("laser enemy hit");

        }

        if (col.gameObject.tag == "redEye")
        {
            Debug.Log("red eye touched");
        }
    }
    //Fall off the platform and you DIE!
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TheVoid")
        {  
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.tag == "NextScene")
        {  
             SceneManager.LoadScene("Game 1");
             Debug.Log("nextscene");
        }
        if (collision.gameObject.tag == "suicideB")
        {  
             SceneManager.LoadScene("S booth");
            
        }
    }
    
        void OnTriggerStay2D(Collider2D collision)
        {
        if (collision.gameObject.tag == "GreenLight")
        {  
            restoreTest(2);
        }
        }
        //------------------


        
    //exit collisions
        void OnCollisionExit2D(Collision2D col)
    {
        damaged = false;
        countdown = 0.1f;
        Debug.Log("resetCount");
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("zero health");
            SceneManager.LoadScene("GameOver");
        }
    }

        void restoreTest(int damage)
        {
        if (currentHealth < 999)
        {
            currentHealth += damage; 
            Debug.Log("resstoreTest111");
            healthBar.SetHealth(currentHealth);
        }
        }
        
   
  
    
 

}





