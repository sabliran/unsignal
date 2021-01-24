using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingFireScript : MonoBehaviour
{
    public GameObject AuraTextSelected;
    public GameObject LaserTextSelected;
  
    public GameObject iconAura;
    public GameObject iconLaser;
  
    
    public playerscript refScript;
    void Start()
    {
        playerscript refScript = GetComponent<playerscript>();
        refScript = GetComponent<playerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (refScript.AuraOn == true)
        {
            AuraTextSelected.SetActive(true);
            iconAura.SetActive(true);
            iconLaser.SetActive(false);
            Invoke("SetFalseAura",1.0f);
        }

        if (refScript.LazerOn == true)
        {
            LaserTextSelected.SetActive(true);
            iconAura.SetActive(false);
            iconLaser.SetActive(true);
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
