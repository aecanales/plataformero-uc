using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {
<<<<<<< HEAD
=======
    public AudioClip retrieveSound;
>>>>>>> Blocks Update, forgot to push

    public string triggerBy = "Player";
    public float maxRange = 100;
    public float velocidad = 10;
    private Vector2 yMovement = new Vector2(0, 0);

    // Use this for initialization
    protected virtual void Start () {
<<<<<<< HEAD
        yMovement.y += transform.position.y;
        yMovement.x += transform.position.x;
=======
        //yMovement.y += transform.position.y;
        //yMovement.x += transform.position.x;
>>>>>>> Blocks Update, forgot to push
		
	}

    // Update is called once per frame
    protected virtual void Update() {
<<<<<<< HEAD
        yMovement.y += maxRange / 2 * Mathf.Sin(velocidad*Time.time);
=======
        //yMovement.y += maxRange / 2 * Mathf.Sin(velocidad*Time.time);
>>>>>>> Blocks Update, forgot to push
    }

    protected virtual void FixedUpdate()
    {
<<<<<<< HEAD
        transform.position = yMovement * Time.fixedDeltaTime;
=======
        //transform.position = yMovement * Time.fixedDeltaTime;
>>>>>>> Blocks Update, forgot to push
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag(triggerBy)) {
            Destroy(gameObject);
        }
    }
<<<<<<< HEAD
}
=======

    /**
     * Plays a sound when you recieve the object.
     */
    public virtual void PlaySound(Vector3 location){
        if (retrieveSound != null){
            AudioSource.PlayClipAtPoint(retrieveSound, location);
        }
    }
}
>>>>>>> Blocks Update, forgot to push
