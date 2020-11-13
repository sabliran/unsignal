using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
public class LevelWindow : MonoBehaviour
{
    public Text levelText;
    public Image experienceBarImage;
    public LevelUpSystem levelSystem;
    private LevelSystemAnimated levelSystemAnimated;
    private void Awake() 
    {
        levelText = transform.Find("levelText").GetComponent<Text>();
        experienceBarImage = transform.Find("experienceBar").Find("Bar").GetComponent<Image>();

        transform.Find("experience5Btn").GetComponent<Button_UI>().ClickFunc = () => levelSystem.AddExperience(5);
        transform.Find("experience50Btn").GetComponent<Button_UI>().ClickFunc = () => levelSystem.AddExperience(50);
        transform.Find("experience500Btn").GetComponent<Button_UI>().ClickFunc = () => levelSystem.AddExperience(500);
    }
    private void SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarImage.fillAmount = experienceNormalized;
    }
    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = "LEVEL: " + (levelNumber + 1);
    }       

    public void SetLevelSystem (LevelUpSystem levelSystem)
    {
        this.levelSystem = levelSystem;
    }

    public void SetLevelSystemAnimated(LevelSystemAnimated levelSystemAnimated)
    {
        //set the levelSystem object 
        this.levelSystemAnimated = levelSystemAnimated;
        //update the starting values
        SetLevelNumber(levelSystemAnimated.GetLevelNumber());
        SetExperienceBarSize(levelSystemAnimated.GetExperienceNormalized());
        //Subscribe to the changed events 
        levelSystemAnimated.OnExperienceChanged += LevelSystemAnimated_OnExperienceChanged;
        levelSystemAnimated.OnLevelChanged += levelSystemAnimated_OnLevelChanged;
    }
    private void levelSystemAnimated_OnLevelChanged(object sender, System.EventArgs e)
    {   //level changed, update text
        SetLevelNumber(levelSystemAnimated.GetLevelNumber());
    }
    private void LevelSystemAnimated_OnExperienceChanged(object sender, System.EventArgs e)
    {
        //experience changed, update bar size
        SetExperienceBarSize(levelSystemAnimated.GetExperienceNormalized());    
    }

}
            