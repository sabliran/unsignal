using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class teleporter : MonoBehaviour
{
    public GameObject dialogueBox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {  
           
           print("teett");
           
           dialogueBox.SetActive(true);
           
            //SceneManager.LoadScene("SCENE");
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

        public void SceeneChangerBase()
        {
            SceneManager.LoadScene("Game");
        }




}
