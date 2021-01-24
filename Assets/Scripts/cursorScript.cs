using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorScript : MonoBehaviour
{
   public Texture2D cursor;
   
   private void changeCursor(Texture2D cursorType)           
{
    // Vector2 hotspot = new Vector2(cursorType.width /2, cursorType.height /2);
    Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
}

   
    // private void Awake()
    // {
    //     //changeCursor(cursor);
    //     // Cursor.lockState = CursorLockMode.Confined;
    // }
}
