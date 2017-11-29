using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Needed for to make the Timer work
    public Text _TimerText;
    float _Timer;

    private LevelManager levelManager;
    
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        //Finds Different scenes by name so timer will change
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_1"))
        {
            _Timer = 120f;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_1_Hard"))
        {
            _Timer = 60f;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_1_Easy"))
        {
            _Timer = 6000f;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_2"))
        {
            _Timer = 120f;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_2_Hard"))
        {
            _Timer = 60f;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_2_Easy"))
        {
            _Timer = 6000f;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_3"))
        {
            _Timer = 120f;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_3_Hard"))
        {
            _Timer = 60f;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_3_Easy"))
        {
            _Timer = 6000f;

        }
    }


    void Update()
    {
        _Timer -= Time.deltaTime;
        //This is for the look of the timer
        int seconds = (int)(_Timer % 60);
        int minutes = (int)(_Timer / 60) % 60;

        string timerStrin = string.Format("{0:00}:{1:00}",minutes,seconds);

        _TimerText.text = timerStrin;
        if (_Timer < 0)
        {
            //Loads Defeat Screen if timer runs out
            levelManager.GameOver();
        }
       
    }
}
   
