using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pessimisticMsgs : MonoBehaviour
{
    public Text txtChanger;
    
    public string[] animalDescriptions = 
{

};
    void Start()
    {
      string myString = animalDescriptions [Random.Range (0, animalDescriptions.Length)];
        txtChanger.text = myString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
