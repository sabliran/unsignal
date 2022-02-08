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

    public Button net1Button;
    public Button net2Button;
    public Button net3Button;
    public Button net4Button;

    public GameObject network1Obj;

    


     

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

    
    private void Awake()
    {
        if (Tp != null)
            GameObject.Destroy(Tp);
        else
            Tp = this;

        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        network1Obj = GameObject.Find("INVENTORY/Inventory Canvas/Classic Schema Full Layout/Main Menu/Net1");
    }



    public void Update()
    {


        if (Network1Bool == true)
        {
            print("network2 is ready");
            
            UnityEngine.UI.Button button = GameObject.Find("INVENTORY/Inventory Canvas/Classic Schema Full Layout/Main Menu/Net2").GetComponent<UnityEngine.UI.Button>();
            button.interactable = true;
        }

        if (Network2Bool == true)
        {
            print("network3 is ready");
            
            net3Button.interactable = true;

        }

        if (Network3Bool == true)
        {
            print("network4 is ready");
            
            net4Button.interactable = true;


        }


    }


}
