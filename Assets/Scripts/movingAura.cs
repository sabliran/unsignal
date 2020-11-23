using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingAura : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float m_Speed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
         m_Rigidbody.velocity = transform.right * m_Speed;
    }
}
