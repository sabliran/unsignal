using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class LevelSystemAnimated
{ 

public event EventHandler OnExperienceChanged;
public event EventHandler OnLevelChanged;
private LevelUpSystem levelSystem;
private bool isAnimating;

private int level;
private int experience;
private int experienceToNextLevel;
public LevelSystemAnimated(LevelUpSystem levelSystem)
{
    SetLevelSystem(levelSystem);
    FunctionUpdater.Create(() => Update());
}

    private void SetLevelSystem(LevelUpSystem levelSystem)
    {
        this.levelSystem = levelSystem;

        level = levelSystem.GetLevelNumber();
        experience = levelSystem.GetExperience();
        experienceToNextLevel = levelSystem.GetExperienceToNextLevel();
        levelSystem.OnExperienceChanged += LevelSytem_OnExperienceChanged;
        levelSystem.OnLevelChanged += LevelSytem_OnLevelChanged;
    }

    private void LevelSytem_OnLevelChanged (object sender, System.EventArgs e)
    {
        isAnimating = true;
    }
    private void LevelSytem_OnExperienceChanged(object sender, System.EventArgs e)
    {
        isAnimating = true;
    }

    private void Update() {
        if(isAnimating)
        {
            if (level < levelSystem.GetLevelNumber())
            {
                //local level under target level
                AddExperience();
            }
            else
            {
                //local level equals target level
                if (experienceToNextLevel < levelSystem.GetExperience())
                {
                    AddExperience();
                }
                else
                {
                    isAnimating = false;
                }
            }
        }
        Debug.Log(level + " " + experience);
    }

    private void AddExperience()
    {
        experience++;
        if(experience >= experienceToNextLevel)
        {
            level++;
            experience = 0;
         if (OnLevelChanged != null) OnLevelChanged(this, EventArgs.Empty);
        }
        if (OnExperienceChanged != null) OnExperienceChanged(this, EventArgs.Empty);
    }

        public int GetLevelNumber()
    {
        return level;
    }

        public float GetExperienceNormalized()
    {
        return (float)experience / experienceToNextLevel;        
    }



}


