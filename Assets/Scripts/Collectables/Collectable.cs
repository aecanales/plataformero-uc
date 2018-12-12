using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public AudioClip retrieveSound;

    public string triggerBy = "Player";
    public Vector2 SpawnForce = new Vector2(120, 250);

    // Use this for initialization
    protected virtual void Start () {
        if (Random.value < 0.5f)
            GetComponent<Rigidbody2D>().AddForce(SpawnForce);
        else
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-SpawnForce.x, SpawnForce.y));
    }

    // Update is called once per frame
    protected virtual void Update()
    { }

    protected virtual void FixedUpdate()
    { }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag(triggerBy)) {
            Debug.Log(gameObject.name + " collided with player.");
            PlaySound(transform.position);
            Destroy(gameObject);
        }
    }

    /**
     * Plays a sound when you recieve the object.
     */
    public virtual void PlaySound(Vector3 location){
        if (retrieveSound != null){
            AudioSource.PlayClipAtPoint(retrieveSound, location);
        }
    }
}
