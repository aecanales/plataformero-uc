using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public string player_tag = "Player";

    private GameObject[] players;
    private GameObject player;

    public float freeMove = 1; //How much the player can move "freely".

    public float cameraY; // The Y value the camera will stay at.
    public float yWaitTime; // The amount of seconds the camera spend in the air before falling to cameraY position.
    private bool hasWaited = false;

    // Use this for initialization
    void Start () {
        players = GameObject.FindGameObjectsWithTag(player_tag);
        player = players[Random.Range(0, players.Length)];
    }
	
	// Update is called once per frame
	void Update () {
        players = GameObject.FindGameObjectsWithTag(player_tag);

        if (!hasWaited) {
            yWaitTime -= Time.deltaTime;

            if (yWaitTime <= 0)
                hasWaited = true;
        }
        else {
            if (transform.position.y > cameraY)
                transform.position = new Vector3(transform.position.x, transform.position.y - 3 * Time.deltaTime, transform.position.z);
        }
    }

    private void LateUpdate()
    {
        float difference = player.transform.position.x - transform.position.x;
        if (Mathf.Abs(difference) > freeMove) {
            if (player.GetComponent<Rigidbody2D>().velocity.x > 0 && difference>0)
            {
                Vector3 next = new Vector3(player.transform.position.x - freeMove, transform.position.y, transform.position.z);
                transform.position = next;
            } else if (player.GetComponent<Rigidbody2D>().velocity.x < 0 && difference < 0){
                Vector3 next = new Vector3(player.transform.position.x + freeMove, transform.position.y, transform.position.z);
                transform.position = next;

            }
        }
    }

    public void ChangePlayer(int n) {
        if (n < 0 || n >= players.Length)
        {
            player = players[Random.Range(0, players.Length)];
        }
        else {
            player = players[n];
        }
    }

}
