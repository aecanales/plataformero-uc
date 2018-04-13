using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour {

    public GameObject message;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Se activó onTriggerStay2D");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Es el player :o");
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("El jugador apretó F");
                message.SetActive(true);
            }
        }
    }
}
