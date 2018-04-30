using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public string player_tag = "Player";
    private GameObject[] players;
    private GameObject player;

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
        Vector3 next = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = next;
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
