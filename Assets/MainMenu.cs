using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject canvas;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame ()
    {
        
        Application.Quit();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            
           
             canvas.transform.localPosition = new Vector3(20f, 3f, -3.75f);
            // canvas.transform.Rotate(0.0f, -50.0f, 0.0f, Space.Self);

        }
    }
        void OnCollisionExit2D(Collision2D col)
    {
       
    }

    
}

