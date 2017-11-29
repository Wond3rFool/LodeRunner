using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Pause : MonoBehaviour {

    private GameObject pauseMenu;


    void Awake ()
    {
        pauseMenu = GameObject.Find("PauseMenuCanvas");
       
        DontDestroyOnLoad(pauseMenu);
        transform.GetChild(0).gameObject.SetActive(false);
    }
    public void OpenMenu()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void CloseMenu()
    {
        UnPause();
    }
    public void RestartScene()
    {
        UnPause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void LoadMainMenu()
    {
        UnPause();
        SceneManager.LoadScene("MainMenu");
        
    }
    public void UnPause()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    void Update ()
    {
		
	}

}
