using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private LevelWindow levelWindow;
    [SerializeField] private playerscript player;
    private void Awake() 
    {
        LevelUpSystem levelSystem = new LevelUpSystem();    
        levelWindow.SetLevelSystem(levelSystem);
        player.SetLevelSystem(levelSystem);

        LevelSystemAnimated levelSystemAnimated = new LevelSystemAnimated(levelSystem);
        levelWindow.SetLevelSystemAnimated(levelSystemAnimated);
    }
}
