using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dcubeScript : MonoBehaviour
{
    public float speedRotate;
void Update()
 {
  transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
  transform.Rotate(Vector3.up * speedRotate * Time.deltaTime);
 }


}
