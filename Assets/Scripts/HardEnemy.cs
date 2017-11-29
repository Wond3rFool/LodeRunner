using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : MonoBehaviour {

    public int enemyHealth;

    public GameObject deathEffect;



    void Start()
    {

    }


    void Update()
    {
        if (enemyHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    public void giveDamage(int damageToGive)
    {
        enemyHealth -= damageToGive;
    }
}
