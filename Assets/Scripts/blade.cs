using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade : MonoBehaviour
{



 
    public float speed = 1f;
    public float delta = 1f;  //delta is the difference between min y to max y.
      void Update() {
     float y = Mathf.PingPong(speed * Time.time, delta);
     Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
     transform.position = pos;
 }
}