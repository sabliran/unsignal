using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyePetScript : MonoBehaviour
{
    
    
    private PlayerControls  playerControls;
    [SerializeField]
    Camera overlay;
    
    Animator animator;
    Vector3 mousePos;
    

    public bool isShooting; 
     
      private void Awake() 
    {
        playerControls = new PlayerControls();
        playerControls.Player.MousePosition.performed += x => mousePos = x.ReadValue<Vector2>();
        
    }
     private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

  
    void Start()
    {
        
        animator = GetComponent<Animator>();
        Vector2 mousePosition = playerControls.Player.MousePosition.ReadValue<Vector2>();
        mousePosition = overlay.ScreenToWorldPoint(mousePosition);
    }

   
    // Update is called once per frame
    void Update()
    {
        float shootInput = playerControls.Player.ShootLaser.ReadValue<float>();



        mousePos.z = 0;
        // Debug.Log(overlay.ScreenToWorldPoint(mousePos));
        Vector2 mouseScreenPosition = playerControls.Player.MousePosition.ReadValue<Vector2>();
        Vector3 mouseWorldPosition = overlay.ScreenToWorldPoint(mouseScreenPosition);
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

        
        if (shootInput == 1)
        {
            animator.SetBool("isShooting", true);
        }else if (shootInput == 0)
        {
            animator.SetBool("isShooting", false);
        }
        
    }

        


}
