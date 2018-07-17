using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class CharacterMovement : MonoBehaviour {
    private float speed = 0f;
    public float acceleration = 20f;
    public float MAX_SPEED = 5f; //Constant
    public float jumpForce = 500f;

    public GameObject groundCheck;
    private Rigidbody2D rigidBody;

    bool inGround = false;
    bool jump = false;

    Animator anim;


    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        if(inGround && Input.GetButtonDown("Jump")){
            jump = true;
        }
        HandleFlip();
    }

    void FixedUpdate(){
        Move();
        Jump();
        if (rigidBody.velocity.y < -0.5f) // If player is falling...
            anim.SetBool("Jumped", true);
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.gameObject.tag.Equals("Ground") && 
            collision.collider.bounds.max.y - 0.1 < GetComponent<Collider2D>().bounds.min.y)
        {
            inGround = true;
            anim.SetBool("Jumped", false);
        }
    }

    private void Jump(){
        if (jump){
            rigidBody.AddForce(Vector2.up * jumpForce);
            Debug.Log("Jumping");
            anim.SetBool("Jumped", true);
            jump = false;
            inGround = false;
        }
    }

    public void ForceJump(float modifier) {
        rigidBody.AddForce(Vector2.up * jumpForce * modifier);
        Debug.Log("Force Jump");
        anim.SetBool("Jumped", true);
        jump = false;
        inGround = false;
    }

    void Move() {
        float xMove = Input.GetAxis("Horizontal");
        anim.SetBool("IsMoving", xMove != 00);
        if(xMove == 0){
            rigidBody.velocity = new Vector2(0,rigidBody.velocity.y);
            return;
        }
        if (speed < MAX_SPEED){
            rigidBody.AddForce(Vector2.right * xMove * acceleration);
        }
        if (speed > MAX_SPEED){
            rigidBody.velocity = new Vector2(Mathf.Sign(rigidBody.velocity.x) * MAX_SPEED, rigidBody.velocity.y);
        }
        speed = Mathf.Abs(rigidBody.velocity.x);
    }

    void HandleFlip() {
        float xAxis = Input.GetAxis("Horizontal");
        if ((xAxis < 0 && gameObject.transform.localScale.x > 0) | (xAxis > 0 && gameObject.transform.localScale.x < 0))
        {
            gameObject.transform.localScale = new Vector3
                (-gameObject.transform.localScale.x, 
                gameObject.transform.localScale.y,
                gameObject.transform.localScale.z);
        }
    }
}
