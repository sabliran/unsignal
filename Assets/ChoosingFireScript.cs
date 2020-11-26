using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingFireScript : MonoBehaviour
{
    public GameObject AuraTextSelected;
    public GameObject LaserTextSelected;
  
    
  
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AuraTextSelected.SetActive(true);
            Invoke("SetFalseAura",1.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LaserTextSelected.SetActive(true);
            Invoke("SetFalseLaser",1.0f);
        }        

  



        
    }

    void SetFalseAura()
    {
        AuraTextSelected.SetActive(false);
    }
    
    void SetFalseLaser()
    {
        LaserTextSelected.SetActive(false);
    }

}
