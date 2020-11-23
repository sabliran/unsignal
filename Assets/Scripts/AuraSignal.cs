// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class AuraSignal : MonoBehaviour
// {
//     public GameObject Aura;
//     private float countTime = 1.0f;


//     private bool auraActive;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//         if (Input.GetButtonDown("Fire1")) 
//         {
            
//             Aura.SetActive(true);
//             auraActive = true;
//         }
        
//         if (auraActive == true)
//         {
//             countTime -= Time.deltaTime;
//             //Debug.Log(countTime);
//         }


//         if (countTime <= 0.0f)
//         {
//             Aura.SetActive(false);
//             countTime = 1.0f;
//         }
  
//     }
// }
