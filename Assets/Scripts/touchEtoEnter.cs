using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchEtoEnter : MonoBehaviour
{
    public GameObject canvas;


    public void PlayGame()
    {
        SceneManager.LoadScene("Pub");
    }

}
