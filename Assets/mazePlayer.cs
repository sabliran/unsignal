using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazePlayer : MonoBehaviour
{
    [SerializeField]    
    private float _speed;
    private PlayerControls _playerAction;
    private Rigidbody2D _rbody;
    private Vector2 _moveInput;
    
    // Start is called before the first frame update
    void Awake()
    {
        _playerAction = new PlayerControls();
        _rbody = GetComponent<Rigidbody2D>();
        if (_rbody is null)
            Debug.LogError("rigidbody is null!");
        
    }

    void start ()
    {
       
    }

    private void OnEnable()
    {
        _playerAction.Player_Map.Enable();
    }
    private void OnDisable()
    {
        _playerAction.Player_Map.Disable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _moveInput = _playerAction.Player_Map.Movement.ReadValue<Vector2>();

        _rbody.velocity = _moveInput * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SwitchCubeFace")
        {
            Debug.Log("switch");
            

        }
    }

    }
