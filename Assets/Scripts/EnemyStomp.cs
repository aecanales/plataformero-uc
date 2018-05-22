using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision){
        string colliderTag = collision.collider.gameObject.tag;
        if (colliderTag.Equals("Enemy"))
        {
            if (collision.collider.bounds.max.y < gameObject.transform.position.y)
            { //We're falling!{
                print(GetComponent<Rigidbody2D>().velocity.y);
                Destroy(collision.collider.gameObject);
                GetComponent<CharacterMovement>().ForceJump(0.5f);
            }
        }
    }
}
