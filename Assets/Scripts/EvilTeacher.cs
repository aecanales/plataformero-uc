using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.Collectables.Abilities;

public class EvilTeacher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
