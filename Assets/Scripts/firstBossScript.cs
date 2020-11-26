using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstBossScript : MonoBehaviour
{
    public enemy refScriptEnemy;
    public ParticleSystem particleInput;
    
    private ParticleSystem particles;
    
    public int addParticle;

    void Start()
    {
        enemy refScriptEnemy = GetComponent<enemy>();
        refScriptEnemy = GetComponent<enemy>();
        particles = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        particles.maxParticles = (addParticle);


        if (refScriptEnemy.gotHit == true)
        {
            
            
            addParticle += 10;

            ///access the particle system and add max particles every time the player is getting hit
            
            
            
        }else
        {
            addParticle = addParticle;
        }
    }
}


