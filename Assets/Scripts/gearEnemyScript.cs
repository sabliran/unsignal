using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearEnemyScript : MonoBehaviour
{
    public Transform Screentip;
    public GameObject RetinaScreen;

    public float speed = 1f;
    public float delta = 1f;  //delta is the difference between min y to max y.
       

      void Update() {
     float x = Mathf.PingPong(speed * Time.time, delta);
     Vector3 pos = new Vector3(x, transform.position.y, transform.position.z);
     transform.position = pos;
 }
    
        void spawnRetina()
        {
            GameObject retina = Instantiate(RetinaScreen, Screentip.position, Screentip.rotation) as GameObject;
        }
     void OnTriggerEnter2D(Collider2D col)
    {
         if(col.gameObject.tag == "Player")
        {  
            spawnRetina(); 
            Debug.Log("passed");
        }


    }

}
