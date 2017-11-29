using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    //Gets CurrentCheckpoint
    public GameObject currentCheckpoint;
    //Finds script
    private MovementController thePlayer;

    //Particle effects for death animation and respawn animation
    public GameObject DeathParticle;
    public GameObject RespawnParticle;

    //Respawns the player after 0.5 seconds
    private float respawnDelay = 0.5f;

    
    void Start ()
    {
        //finds The player
        thePlayer = FindObjectOfType<MovementController>();
    }
	
    public void RespawnPlayer()
    {
        //Starts the Respawn animation
        StartCoroutine("respawnPlayerCo");
    }
    public IEnumerator respawnPlayerCo()
    {
        //Death Animation
        Instantiate(DeathParticle, thePlayer.transform.position, thePlayer.transform.rotation);
        thePlayer.enabled = false;
        thePlayer.GetComponent<Renderer>().enabled = false;
        thePlayer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        thePlayer.GetComponent<Rigidbody2D>().gravityScale = 0f;
        yield return new WaitForSeconds(respawnDelay);

        //Respawn animation
        thePlayer.GetComponent<Rigidbody2D>().gravityScale = 1f;
        thePlayer.transform.position = currentCheckpoint.transform.position;
        thePlayer.enabled = true;
        thePlayer.GetComponent<Renderer>().enabled = true;
        Instantiate(RespawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }
    public void GameOver()
    {
        //Loads GameOverScreen
        SceneManager.LoadScene("Defeat");
    }
}
