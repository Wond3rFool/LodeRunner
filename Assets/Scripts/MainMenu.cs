using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    //Insert Scene names 
    public string startLevel;
    public string _Controls;
    public string _MainMenu;

    public void NewGame()
    {
        //Loads startLevel
        SceneManager.LoadScene(startLevel);
    }

    public void Controls()
    {
        //Loads Control Menu
        SceneManager.LoadScene(_Controls);
    }
    public void mainMenu()
    {
        //Loads Main Menu
        SceneManager.LoadScene(_MainMenu);
    }
    public void QuitGame()
    {
        //Quits the game
        Application.Quit();
    }
    public void Mute()
    {
        //Mutes the audio
        AudioListener.pause = true;
    }
    public void UnMute()
    {
        //UnMutes the audio
        AudioListener.pause = false;
    }

}
