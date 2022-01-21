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
    public bool isJumping;
  
    public float projectileSpeed;
    private bool faceRight;
    private float bulletDecay = 2;
    public bool damaged;
    
    [SerializeField] protected int currentHealth;
    [SerializeField] protected int maxHealth;

    public HealthBar healthBar;
    public float countdown = 1.0f;
    public GameObject pointLight;

    public TextMeshProUGUI healthNumbers;
    public GameObject AuraPrefab;
    public GameObject laserPrefab;
    private PlayerControls  playerControls;
    private Collider2D col;
    public LayerMask whatIsGround;
    public float JumpForce;
    public bool LazerOn;
    public bool AuraOn;

    
    public int weaponNumber;
    public int damage;
    
    public bool isMoving;
    public float movementInput;

    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    Animator animator;
    public ParticleSystem dust;  

    public GameObject MiniMap;
    public bool ActiveMap;

    public float timeRemaining = 100;

    public bool ActivateButtonBool;
    public GameObject AgoraEnterText;
   



    private void Awake() 
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

    }
    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    void Start()
    {
       
        dashTime = startDashTime;
        animator = GetComponent<Animator>();
        ActiveMap = false;
        // maximize fps
        Application.targetFrameRate = 300;
    }
    

    public void OnJump()
    {
        HandleJump();
    isJumping = true;
    
    }

    public void OnActivateButton()
    {
        ActivateButtonBool = true;

    }



    public void OnShootLaser()
    {
        
        if (weaponNumber == 0)
        {
            LaserShoot();
            

        }
        if (weaponNumber == 1)
        {
            auraShoot();
        }
        animator.SetBool("isShooting", true);

    }
///////////////////////////////////////////////////////////////////////////////////////
    public void OnToggleMap()
    {
        

      
       
           MiniMap.SetActive(!MiniMap.activeSelf);

    
        
    }
   /////////////////////////////////////////////////////////////////////////////////////

// switches between the weaponNumber switch function (in the update function)
    public void OnChangeWeapon()
    {
        weaponNumber++;
        
        if (weaponNumber == 0)
        {
            LazerOn = true;
        }else
        {
            LazerOn = false;
        }

        if (weaponNumber == 1)
        {
            AuraOn = true;
        }else
        {
            AuraOn = false;
        }

        if (weaponNumber == 2)
        {
            // stops counting and sets weaponNumber to 0
            weaponNumber = 0;
        }
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void LaserShoot()
    {
        GameObject laser = Instantiate(laserPrefab, Screentip.position, Screentip.rotation) as GameObject;
        Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        rb.AddForce(Screentip.right * projectileSpeed, ForceMode2D.Impulse);
        Destroy (laser, 1.8f);
        LazerOn = true;
        AuraOn = false;
        animator.SetBool("isShooting", true);
    }

   public void auraShoot()
    {
        GameObject aura = Instantiate(AuraPrefab, Screentip.position, Screentip.rotation) as GameObject;
        Rigidbody2D rb = aura.GetComponent<Rigidbody2D>();
        rb.AddForce(Screentip.right * projectileSpeed, ForceMode2D.Impulse);
        Destroy (aura, 0.3f);
        LazerOn = false;
        AuraOn = true;
    }

  


    void Update() //----------------------------------------------------UPDATE START-----------------------------------------------------
    {
       
        switch (weaponNumber)
    {
        case 1 :
            
            AuraPrefab.SetActive(true);
            break;

        default:
            laserPrefab.SetActive(true);
            break;
    }



        
    float movementInput = playerControls.Player.Move.ReadValue<float>();
        if(movementInput != 0)
        {
            isMoving = true;
            animator.SetBool("isWalking", true);
            
        }
        else
        {
            isMoving = false;
            animator.SetBool("isWalking", false);
           
        }
        

        float dashInput = playerControls.Player.Dash.ReadValue<float>();

        //0 = not pressed
        //1 = pressed


        if (direction == 0)
        {

            if (dashInput == 1)
            {
                CreateDust();
                
                if (movementInput == -1)
                {
                    direction = 1;
                }
                else if (movementInput == 1)
                {
                    direction = 2;
                }
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;


                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }

            }
        }




        //DASH ANIM
        if (dashInput == 1)
    {
        animator.SetBool("isDash", true);
    }else
    {
        animator.SetBool("isDash", false);
    }

     
    //MELEE ANIM
        float meleeInput = playerControls.Player.MeleeAttack.ReadValue<float>();
        if (meleeInput == 1)
        {
            animator.SetBool("melee", true);
        }
        else
        {
            animator.SetBool("melee", false);
        }






        float jumpInput = playerControls.Player.Jump.ReadValue<float>();
        
        if(jumpInput == 1)
        {
            isJumping = true;
            animator.SetBool("isJumpingAnim", true);
        }
        else
        {
            isJumping = false;
            animator.SetBool("isJumpingAnim", false);
        }





        //move the player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * speed * Time.deltaTime;
        transform.position = currentPosition;
        

        
        
        
    

        //Damage Anim
        if (damaged == true)
        {
            animator.SetBool("isDamaged", true);
            
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
            animator.SetBool("isDamaged", false);

           
        }

        if (movementInput > 0 && faceRight)
        {
            flip();
            CreateDust();
            
        }
        else if (movementInput < 0 && !faceRight)
        {    
            flip();
            dust.transform.Rotate(0f, 180f, 0f);
            CreateDust();
            
        }
        
        
        Math.Round(bulletDecay);

        healthNumbers.text = currentHealth.ToString();    
        

 
    } //--------------------------------------------------------------------------UPDATE END---------------------------------------------




    public void Heal(int amount)
    {
        if(amount <= 0) { return; }
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }




    // play particle function
    void CreateDust()
    {
        dust.Play();
    }

   
    void flip()
    {
        faceRight = !faceRight;
        transform.Rotate(0f, 180f, 0f);
    }    

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            
            SceneManager.LoadScene("GameOver");
        }
    }

 

    public void HandleJump()
    {
        float Jumpfloat = playerControls.Player.Jump.ReadValue<float>();
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && Jumpfloat < 1)
        {
            
            CreateDust();
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * Jumpfloat;
            
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
            
        }
        
        if (col.gameObject.tag == "enemy")
        {
            damaged = true;
            
        }
        
        if (col.gameObject.tag == "enemyLaser")
        {
            damaged = true;
            

        }

        if (col.gameObject.tag == "redEye")
        {
           
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
             
        }
        if (collision.gameObject.tag == "suicideB")
        {  
             SceneManager.LoadScene("S booth");
            
        }
        
        if (collision.gameObject.tag == "ObstacleRedLaser")
        {
            // damaged = true;
           
            
        }

        if (collision.gameObject.tag == "PuzzleCube")
        {
            print("puzzleCube touched");
            
            
            SceneManager.LoadScene("1cubepuzzle");


        }

    }
    
        void OnTriggerStay2D(Collider2D collision)
        {



            if (collision.gameObject.tag == "GreenLight")
            {  
                Heal(2);
            }


        if (collision.gameObject.tag == "agoraEnterCollider")
        {
            AgoraEnterText.SetActive(true);

            if (ActivateButtonBool == true)
            {
                SceneManager.LoadScene("Pub");
            }

            
        }

        }
        
        void OnTriggerExit2D(Collider2D other)
        {

        if (other.gameObject.tag == "agoraEnterCollider")
        {
            
            AgoraEnterText.SetActive(false);
        }

    }

        void OnCollisionExit2D(Collision2D col)
    {
        damaged = false;
        countdown = 0.1f;



    }
        

    //--------------------------------------------------------------------------------------exit collisions
  
    
 

}





