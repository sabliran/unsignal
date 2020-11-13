using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneScript : MonoBehaviour
{
    private float countTime = 1.5f;
    public GameObject title;

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime;
        if (countTime <= 0.0f)
            {
                title.SetActive(false);
            }
    }
}
