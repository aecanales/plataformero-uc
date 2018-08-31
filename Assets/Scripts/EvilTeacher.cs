using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.Collectables.Abilities;

public class EvilTeacher : MonoBehaviour {

    private Vector3 initialPos;
    private float sine;

    public float horizontalMovement;
    public float speed;

	// Use this for initialization
	void Start () {
        initialPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Mirror();
        Vector3 newPos = initialPos;
        sine = Mathf.Sin(Time.time * speed);
        newPos.x += horizontalMovement * sine;
        transform.position = newPos;
	}

    void Mirror() {
        if (sine - Mathf.Sin(Time.time * speed) > 0) // decreasing sine, going to left
            transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        else // increasing sine, going to right
            transform.localScale = new Vector3(0.5f, 0.5f, 1);
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
