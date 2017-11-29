using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private ScoreManager _Score;

    //public string _MainMenu;


    void Start()
    {
        //Keys Collected in the current scene.
        _Score = FindObjectOfType<ScoreManager>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        //Checks how many keys the player has so he can move to the next level
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_1"))
        {
            if (other.name == "Main_Character"  && _Score.currentscore == 2)
             {
                SceneManager.LoadScene("Level_2");
             }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_1_Hard"))
        {
            if (other.name == "Main_Character"  && _Score.currentscore == 3)
            {
                SceneManager.LoadScene("Level_2_Hard");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_1_Easy"))
        {

            if (other.name == "Main_Character" && _Score.currentscore == 2)
            {
                SceneManager.LoadScene("Level_2_Easy");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_2"))
        {

            if (other.name == "Main_Character"  && _Score.currentscore == 3)
            {
                SceneManager.LoadScene("Level_3");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_2_Hard"))
        {
            if (other.name == "Main_Character"  && _Score.currentscore == 4)
            {
                SceneManager.LoadScene("Level_3_Hard");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_2_Easy"))
        {

            if (other.name == "Main_Character"  && _Score.currentscore == 2)
            {
                SceneManager.LoadScene("Level_3_Easy");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_3"))
        {

            if (other.name == "Main_Character"  && _Score.currentscore == 5)
            {
                SceneManager.LoadScene("Victory");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_3_Hard"))
        {
            if (other.name == "Main_Character"  && _Score.currentscore == 6)
            {
                SceneManager.LoadScene("Victory");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level_3_Easy"))
        {

            if (other.name == "Main_Character"  && _Score.currentscore == 3)
            {
                SceneManager.LoadScene("Victory");
            }
        }
    }
    
}
