using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doggo : MonoBehaviour {

    public GameObject message;
    public GameObject pressf;
    public string FinalScene;
    private Animator anim;

	// Use this for initialization
	void Start () {
        pressf.SetActive(true);
        anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

	}


    private IEnumerator OnTriggerStay2D(Collider2D collision) //cambiar void por IEnumerator permite iterar para que pasen 5 segundos
    {
        Debug.Log("Se activó onTriggerStay2D");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Es el player :o");

            if (Input.GetKeyDown(KeyCode.F))
            {
                pressf.SetActive(false);
                Debug.Log("El jugador apretó F");
                message.SetActive(true);
                anim.SetBool("speaking", true);
                collision.gameObject.GetComponent<CharacterMovement>().enabled = false;
                yield return new WaitForSeconds(5); // funcion que detecta el paso del tiempo
                message.SetActive(false);
                pressf.SetActive(true);
                anim.SetBool("speaking", false);
                Debug.Log("Pasan 5 segundos");
                SceneManager.LoadScene(FinalScene);
            }
        }
    }
}
