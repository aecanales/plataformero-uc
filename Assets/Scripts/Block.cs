using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class Block : MonoBehaviour {
    public Collectable prizeObject; //Objeto que será entregado al jugador.
    public BlockType type = BlockType.Breakable;
    public Sprite newBlock; // Block sprite after being hit, only for item blocks.
    private bool hit = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision){
        if (!hit){
            if (collision.collider.bounds.max.y < gameObject.transform.position.y) { //check if below player   
                switch (type) {
                    case BlockType.Breakable:
                        GetComponent<AudioSource>().Play();
                        GetComponent<SpriteRenderer>().enabled = false;
                        Destroy(gameObject, 0.5f);
                        break;
                    case BlockType.Item:
                        Vector3 new_position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                        prizeObject.PlaySound(gameObject.transform.position);
                        Collectable item = Instantiate(prizeObject, new_position, Quaternion.identity);
                        hit = true;
                        GetComponent<SpriteRenderer>().sprite = newBlock;
                        break;
                }
            }
        }
    }
}