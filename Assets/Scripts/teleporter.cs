using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class teleporter : MonoBehaviour
{
    public static teleporter Tp;

    public bool Network1Bool;
    public bool Network2Bool;
    public bool Network3Bool;
    public bool Network4Bool;

    /*public Button net1Button;
    public Button net2Button;
    public Button net3Button;
    public Button net4Button;*/

    public Button network1Obj;
    public Button network2Obj;
    public Button network3Obj;
    public Button network4Obj;


    


     

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

    
    public void Awake()
    {
        if (Tp != null)
            GameObject.Destroy(Tp);
        else
            Tp = this;

        DontDestroyOnLoad(this);

        network1Obj = GameObject.Find("INVENTORY/Inventory Canvas/Classic Schema Full Layout/Main Menu/Net1").GetComponent<Button>();
        network2Obj = GameObject.Find("INVENTORY/Inventory Canvas/Classic Schema Full Layout/Main Menu/Net2").GetComponent<Button>();
        network3Obj = GameObject.Find("INVENTORY/Inventory Canvas/Classic Schema Full Layout/Main Menu/Net3").GetComponent<Button>();
        network4Obj = GameObject.Find("INVENTORY/Inventory Canvas/Classic Schema Full Layout/Main Menu/Net4").GetComponent<Button>();


    }

    private void Start()
    {
    }



    public void Update()
    {


        if (Network1Bool == true)
        {
            print("network2 is ready");

            //net2Button.interactable = true;
            network2Obj.interactable = true;
            
        }

        if (Network2Bool == true)
        {
            print("network3 is ready");

            //net3Button.interactable = true;
            network3Obj.interactable = true;

        }

        if (Network3Bool == true)
        {
            print("network4 is ready");
            
            //net4Button.interactable = true;
            network4Obj.interactable = true;


        }


    }


}
