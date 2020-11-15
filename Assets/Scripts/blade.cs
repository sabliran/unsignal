using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade : MonoBehaviour
{
    public GameObject Blade;
    private float countTime = 1.5f;


 
    void Update()
    {


        countTime -= Time.deltaTime;
            if (countTime <= 0.0f)
                {
                    Blade.SetActive(false);
                    countTime = 1.5f;
                }

        countTime = Time.timeSinceLevelLoad;
        Debug.Log(countTime);
        
        
    }
}
