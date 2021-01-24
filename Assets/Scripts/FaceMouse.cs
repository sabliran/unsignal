using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FaceMouse : MonoBehaviour
{
PlayerControls Obj_PlayerInputActions;
Vector2 input_View; 

private void Awake()
{
  Obj_PlayerInputActions = new PlayerControls();
  Obj_PlayerInputActions.Player.MouseAim.performed += x => input_View = x.ReadValue<Vector2>();
}
  
private void Update()
{
  Debug.Log(input_View);  
  
}


} 