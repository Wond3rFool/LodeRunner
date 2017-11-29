using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    //Amount of enemyHealth
    public int enemyHealth;
    //Particle effect for GameObject Death
    public GameObject deathEffect;


	void Update () {
	    if (enemyHealth <= 0)
        {
            //calls up particle effect for death
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
	}
    public void giveDamage(int damageToGive)
        {
            //Amount of damage the enemy will take
            enemyHealth -= damageToGive;
        }
}
