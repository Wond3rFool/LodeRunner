using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    //amount of points to hurt the enemy
    public int damageToGive;
    //points for bounce back on enemy head
    public float bounceOnEnemy;

    private Rigidbody2D myRigidBody2D;


	void Start ()
    {
        //Gets the rigidbody of the object with this script
        myRigidBody2D = transform.parent.GetComponent<Rigidbody2D>();
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        //Damages the enemy if you jump on them
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealthManager>().giveDamage(damageToGive);
            myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, bounceOnEnemy);
        }
       
    }
}
