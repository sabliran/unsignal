using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableBrick : MonoBehaviour
{
    public bool gotHit;
    public ParticleSystem dust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)

    {
        

        if (col.collider.tag == "bullet")
        {
            gotHit = true;
            Destroy(this.gameObject, 0.1f);
            createDust();
        }

    }

        void Update()
    {

        
    }

    void createDust()
    {
        dust.Play();
    }
}
