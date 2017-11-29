using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class DifficultyLoader : MonoBehaviour {

    public string _Easy;
    public string _Normal;
    public string _Hard;
    public string _MainMenu;

    public void Easy()
    {
        //Loads easy mode
        SceneManager.LoadScene(_Easy);
    }

    public void Normal()
    {
        //Loads normal mode
        SceneManager.LoadScene(_Normal);
    }
    public void Hard()
    {
        //Loads hard mode
        SceneManager.LoadScene(_Hard);
    }
    public void mainMenu()
    {
        //Loads MainMenu
        SceneManager.LoadScene(_MainMenu);
    }
}
