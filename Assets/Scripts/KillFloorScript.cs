using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloorScript : MonoBehaviour {

    private LevelManager levelManager;


    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Kills the Player
        if (other.name == "Main_Character")
        {
            levelManager.RespawnPlayer();
        }
    }
}
