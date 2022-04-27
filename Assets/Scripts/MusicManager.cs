using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    private static MusicManager musicManagerInstance;
    private void Awake() 
    {
        audioSource = GetComponent<AudioSource>();
       /* DontDestroyOnLoad(this); */
        
        if (musicManagerInstance == null)
        {
            musicManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
