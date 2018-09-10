using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.Collectables.Abilities;

public class EvilTeacher : MonoBehaviour {

    private Animator anim;
    private bool dead;

    private Vector3 initialPos;
    private float sine;

    private float deathForce = 13;
    private float gravity = 25;

    public float horizontalMovement;
    public float speed;

	// Use this for initialization
	void Start () {
        initialPos = transform.position;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        

        if (!dead)
        {
            SineMirror();
            sine = Mathf.Sin(Time.time * speed);
            Vector3 newPos = initialPos;
            newPos.x += horizontalMovement * sine;
            transform.position = newPos;
        }
        else {
            transform.position = new Vector3(transform.position.x, transform.position.y + deathForce * Time.deltaTime, -2);
            deathForce -= gravity * Time.deltaTime;
        }
	}

    void SineMirror() {
        if (sine - Mathf.Sin(Time.time * speed) > 0) // decreasing sine, going to left
            transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        else // increasing sine, going to right
            transform.localScale = new Vector3(0.5f, 0.5f, 1);
    }

    void Mirror() {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    void Die() {
        GetComponent<BoxCollider2D>().enabled = false;
        dead = true;
        anim.SetBool("dead", true);
        InvokeRepeating("Mirror", 0, 0.25f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If it's the player, I (the enemy) am NOT below the player and player is NOT invencible, restart level.
        if (collision.gameObject.CompareTag("Player") && 
            !(GetComponent<Collider2D>().bounds.max.y - 0.1 < collision.collider.bounds.min.y) &&
            !collision.gameObject.GetComponent<NotesAbility>().AbilityActive)
        {
            Scene loadedLevel = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadedLevel.buildIndex);
        }
    }
}
