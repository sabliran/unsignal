using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PauseSystem : MonoBehaviour
{

    private PlayerControls playerControls;
    private void Awake()
    {
        playerControls = new PlayerControls();
  
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnInvetory()
    {
        print("inventory Opened");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
