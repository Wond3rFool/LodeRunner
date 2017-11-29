using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    

    //Movement
    public float speed;
    public float jump;
    float moveVelocity;

    //Checking for Terrain
    public Transform groundCheck;
    public float groundcheckradius;
    public LayerMask whatIsGround;
    public bool isGrounded = true;

    
    

    //All needed to move on ladders
    public bool onLadder;
    public float climpSpeed;
    public float climbVelocity;
    public float gravityStore;
    public int _ChildCount;

    //Animator for Character
    private Animator anim;
   

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    void FixedUpdate()
    {
        //Checks if player is on the ground.
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundcheckradius, whatIsGround);

        //Check the amount of children on the MainCharacter
        _ChildCount = transform.childCount;
    }

    void Update()
    {
        //Animation conditions for OnLadder animation
        if (isGrounded)
        {
            anim.SetBool("Grounded", true);
        }
        if (!isGrounded)
        {
            anim.SetBool("Grounded", false);
        }
        if (isGrounded && !onLadder)
        {
            anim.SetBool("OnLadder", false);
        }
        if (!isGrounded && !onLadder)
        {
            anim.SetBool("OnLadder", false);
        }
        if (!isGrounded && onLadder)
        {
            anim.SetBool("OnLadder", true);
        }
       
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            moveVelocity = speed;
        }
        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        
        if (onLadder)
        {
            //sets gravity of player to 0 and allows player to move up the ladder
            GetComponent<Rigidbody2D>().gravityScale = 0f;
            climbVelocity = climpSpeed * Input.GetAxisRaw("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, climbVelocity);
        }
        if (!onLadder)
        {
            //restore gravity if player leaves the ladder
            GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        }

        //WijzigingsOpdracht Code
        if (Input.GetKey(KeyCode.LeftControl) )
        {
            if (Input.GetKeyDown(KeyCode.O))
            { 
                //Changes the layer of the player so enemies don't collide.
                this.gameObject.layer = LayerMask.NameToLayer("Invincible");
            }
        }
        //WijzigingsOpdracht Code
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                // get all enemies with tag enemy and destroy them
                GameObject[] enemy_Normal = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject enemy in enemy_Normal)
                GameObject.Destroy(enemy);
            }
        }
        //WijzigingsOpdracht Code
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //increase speed Main Character until 10
            if (Input.GetKeyDown(KeyCode.KeypadPlus) && speed < 10)
            {
                speed = (speed + 2);

            }
        }
        //WijzigingsOpdracht Code
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //Decrease Speed main Character until 2
            if (Input.GetKeyDown(KeyCode.KeypadMinus) && speed > 2)
            {
                speed = (speed - 2);

            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
            //checking if the player is on the ground
            isGrounded = true;     
    }
    
}