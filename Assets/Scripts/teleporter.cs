using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class teleporter : MonoBehaviour
{
    public GameObject dialogueBox;
    public LevelCheckScript lvlScriptCheck;
    public GameObject net1;
    public GameObject netw2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {  
           
           
           
           dialogueBox.SetActive(true);
           
            
        }

 

    }
         private void OnTriggerExit2D(Collider2D collision) {
            
        
        if (collision.gameObject.tag == "Player")
        {  
            dialogueBox.SetActive(false);
        }
            
            
        }


        public void SceeneChanger()
        {
            SceneManager.LoadScene("net1");
        }

        public void net2()
        {
            SceneManager.LoadScene("net2");
        }

            public void net3()
        {
            SceneManager.LoadScene("net3");
        }

                    public void net4()
        {
            SceneManager.LoadScene("net4");
        }

        public void SceeneChangerBase()
        {
            SceneManager.LoadScene("Game");
        }

    public void Update()
    {

        if (lvlScriptCheck.Network1 == true)
        {
            print("network2 true");
            netw2.SetActive(true);


        }
    }


}
