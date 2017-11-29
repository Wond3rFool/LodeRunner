using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolScript : MonoBehaviour {

    public float moveSpeed = 3f;
    public bool moveRight;

    public Transform wallCheck;
    public float wallcheckradius;
    public LayerMask whatIsWall;
    private bool atWall;

    private bool notAtEdge;
    public Transform edgeCheck;

    private Animator anim;


    void Start () {
        anim = GetComponent<Animator>();
    }
	
	
	void Update () {
        atWall = Physics2D.OverlapCircle(wallCheck.position, wallcheckradius, whatIsWall);

        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallcheckradius, whatIsWall);

        if (atWall || !notAtEdge)
        {
            moveRight = !moveRight;

        }

        if (moveRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }
}
