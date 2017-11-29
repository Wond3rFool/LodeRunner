using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour {

    private MovementController thePlayer;
	
	void Start () {
        //Finds The player 
        thePlayer = FindObjectOfType<MovementController>();
	}
    void Update()
    {
        //Drops the Ladder
        if (Input.GetKeyDown(KeyCode.Q) && thePlayer.isGrounded && !thePlayer.onLadder)
        {
            this.transform.parent = null;
        }
    }

	void OnTriggerEnter2D (Collider2D other)
    {
        //Checks if the player is on the ladder.
        if (other.name == "Main_Character")
        {
            thePlayer.onLadder = true;
        }
    }
   void OnTriggerStay2D(Collider2D other)
    {
        //Lets the player pick up the ladder
        if (other.name == "Main_Character" && Input.GetKeyDown(KeyCode.E) && thePlayer.isGrounded && thePlayer._ChildCount < 4)
        {
            transform.parent = other.transform;
        }
    } 

    void OnTriggerExit2D(Collider2D other)
    {
        //Player is not on the ladder anymore
        if (other.name == "Main_Character")
        {
            thePlayer.onLadder = false;
        }
    }

}
