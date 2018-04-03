using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public string triggerBy = "Player";
    public float maxRange = 100;
    public float velocidad = 10;
    private Vector2 yMovement = new Vector2(0, 0);

    // Use this for initialization
    protected virtual void Start () {
        yMovement.y += transform.position.y;
        yMovement.x += transform.position.x;
		
	}

    // Update is called once per frame
    protected virtual void Update() {
        yMovement.y += maxRange / 2 * Mathf.Sin(velocidad*Time.time);
    }

    protected virtual void FixedUpdate()
    {
        transform.position = yMovement * Time.fixedDeltaTime;
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag(triggerBy)) {
            Destroy(gameObject);
        }
    }
}
