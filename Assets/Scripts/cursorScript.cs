using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorScript : MonoBehaviour
{
   public Texture2D cursorArrow;
    void Start()
    {
        //This is all the code it needs to change the cursor's icon.
       Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}
