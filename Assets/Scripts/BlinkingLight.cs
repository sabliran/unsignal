using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    public GameObject BlinkLight;
  


    
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        BlinkLight.SetActive(false);
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        BlinkLight.SetActive(true);
        timeDelay = Random.Range(0.01f, 1.5f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }

}
