﻿using System.Collections;
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

    private IEnumerator OnTriggerStay2D(Collider2D collision) //cambiar voit por IEnumerator permite iterar para que pasen 5 segundos
    {
        Debug.Log("Se activó onTriggerStay2D");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Es el player :o");
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("El jugador apretó F");
                message.SetActive(true);
                yield return new WaitForSeconds(5); // funcion que detecta el paso del tiempo
                message.SetActive(false);
                Debug.Log("Pasan 5 segundos");

            }
        }
    }
}
