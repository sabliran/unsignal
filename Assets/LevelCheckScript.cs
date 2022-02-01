using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckScript : MonoBehaviour
{
    public bool Network1;
    public bool Network2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Network1 = true;
            Network2 = true;
        }
    }

    

}