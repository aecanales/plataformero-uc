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


    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update(){
        if(inGround && Input.GetButtonDown("Jump")){
            jump = true;
        }
    }

    void FixedUpdate(){
        Move();
        Jump();
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.gameObject.tag.Equals("Ground")){
            inGround = true;   
        }
    }

    private void Jump(){
        if (jump){
            rigidBody.AddForce(Vector2.up*jumpForce);
            Debug.Log("Jumping");
            jump = false;
            inGround = false;
        }
    }

    void Move() {
        float xMove = Input.GetAxis("Horizontal");
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
        speed = rigidBody.velocity.magnitude;
    }
}
