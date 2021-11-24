using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchRotateScript : MonoBehaviour
{
    public GameObject cubeObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cubeObj.GetComponent<CubeRotate>().cubeRotateFunction();
            Debug.Log("Player has touched");
        }
    }
}
