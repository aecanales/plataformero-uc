using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public string player_tag = "Player";
    private GameObject[] players;
    private GameObject player;

    public float freeMove = 1; //How much the player can move "freely".

    // Use this for initialization
    void Start () {
        players = GameObject.FindGameObjectsWithTag(player_tag);
        player = players[Random.Range(0, players.Length)];
    }
	
	// Update is called once per frame
	void Update () {
        players = GameObject.FindGameObjectsWithTag(player_tag);
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
