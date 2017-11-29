using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    public int pointsToAdd;

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys the Key and adds points to the score
        if (other.GetComponent<MovementController>() == null)
            return;
        ScoreManager.AddPoints(pointsToAdd);
        Destroy(gameObject);
    }
}
