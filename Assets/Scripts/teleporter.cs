using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class teleporter : MonoBehaviour
{
    public static teleporter Tp;

    

     

        //Changing SCENES==============================================================================
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


    //===================================================================================================

    
   

    private void Start()
    {
    }



    public void Update()
    {





    }


}
