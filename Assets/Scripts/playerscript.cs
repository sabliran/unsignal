using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Threading;
using TMPro;
using UnityEngine.InputSystem;



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
    
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    [SerializeField] private LayerMask Ground;
    
    private float jumpTimeCounter;
    public float jumpTime;
   
    public float jumpSpeed;
    private bool isJumping;
    [SerializeField] GameObject AuraPrefab;
    [SerializeField] float projectileSpeed;
    private bool faceRight;
    private float bulletDecay = 2;
    public bool damaged;
    public int maxHealth = 1000;
    public int currentHealth;
    public HealthBar healthBar;
    public float countdown = 1.0f;
    public GameObject pointLight;

    public TextMeshProUGUI healthNumbers;
    public GameObject laserPrefab;
    private PlayerControls  playerControls;
    private Collider2D col;
    public LayerMask whatIsGround;
    public float JumpForce;
    private void Awake() 
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }
    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
 

 
public void OnJump()
{
    HandleJump();
}



    void Update() //----------------------------------------------------UPDATE START-----------------------------------------------------
    {
        
        float movementInput = playerControls.Player.Move.ReadValue<float>();

       
        //move the player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * speed * Time.deltaTime;
        transform.position = currentPosition;
        

        
        
        // --------Jump Mechanics
    


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
        // float moveHorizontal = Input.GetAxis("Horizontal");

       
        if (movementInput > 0 && faceRight)
        {
            flip();
            
            
        }
        else if (movementInput < 0 && !faceRight)
        {    
            flip();
            
        }
        Fire();
        
        Math.Round(bulletDecay);

        healthNumbers.text = currentHealth.ToString();    


    } //--------------------------------------------------------------------------UPDATE END---------------------------------------------
        void flip()
    {
        faceRight = !faceRight;
        transform.Rotate(0f, 180f, 0f);
    }    

    void Fire()
    {
        // //------------------Aura
        // if (Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     laserPrefab.SetActive(false);
        //     AuraPrefab.SetActive(true);
        // }
        
        // if (Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     AuraPrefab.SetActive(false);
        //     laserPrefab.SetActive(true);
        // }
        
       
       
       
    //    if (Input.GetButtonDown("Fire1"))
    //     {
    //         //Instantiate Bullet
    //         GameObject AuraShoot = Instantiate(AuraPrefab, Screentip.position, Screentip.rotation) as GameObject;
    //         Rigidbody2D rb = AuraShoot.GetComponent<Rigidbody2D>();
    //         rb.AddForce(Screentip.right * projectileSpeed, ForceMode2D.Impulse);

    //         // AuraShoot.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);

    //             // Destroy(laser);               
    //             // Debug.Log(bulletDecay);
    //             Destroy (AuraShoot, 10f);
    //     }

        //---------------------Laser
    //     if (Input.GetButtonDown("Fire1"))
    //     {
    //         //Instantiate Bullet
    //         GameObject laser = Instantiate(laserPrefab, Screentip.position, Screentip.rotation) as GameObject;
    //         Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
    //         rb.AddForce(Screentip.right * projectileSpeed, ForceMode2D.Impulse);

    //         //laser.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);

    //             // Destroy(laser);               
    //             // Debug.Log(bulletDecay);
    //             Destroy (laser, 0.3f);
    //     }
        
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

        public void HandleJump()
        { 
        float Jumpfloat = playerControls.Player.Jump.ReadValue<float>();
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && Jumpfloat < 1)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * Jumpfloat;
            Debug.Log("jump");
        }

        if(isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * JumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else {
                isJumping = false;  
                          
                }
        }

        if (Jumpfloat == 0f)
        {
            isJumping = false;
        }


        }

        
   
    //------------------------------------------------------------------------------Collision detection
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

        // if (col.gameObject.tag == "Obstacle")
        // {
        //     damaged = true;
        //     Debug.Log("hit");
        // }
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
        
        if (collision.gameObject.tag == "ObstacleRedLaser")
        {
            // damaged = true;
           
            Debug.Log("hit");
        }
    }
    
        void OnTriggerStay2D(Collider2D collision)
        {
        if (collision.gameObject.tag == "GreenLight")
        {  
            restoreTest(2);
        }
        }
        


        void OnCollisionExit2D(Collision2D col)
    {
        damaged = false;
        countdown = 0.1f;
        Debug.Log("resetCount");
    }
        
    //--------------------------------------------------------------------------------------exit collisions
  
    
 

}





