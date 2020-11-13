using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouse : MonoBehaviour
{
  public GameObject laserPrefab;
  public Transform Screentip;
  public float projectileSpeed;
   
    private void Update() 
    {
     Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
     float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
     transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

       

        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate Bullet
            GameObject laser = Instantiate(laserPrefab, Screentip.position, Screentip.rotation);
            Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
            rb.AddForce(Screentip.right * projectileSpeed, ForceMode2D.Impulse);

            //laser.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);

                // Destroy(laser);               
                // Debug.Log(bulletDecay);
                Destroy (laser, 0.3f);
        }
    }

}