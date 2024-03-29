﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision){
        string colliderTag = collision.collider.gameObject.tag;
        if (colliderTag.Equals("Enemy"))
        {
            if (collision.collider.bounds.max.y - 0.1 < GetComponent<Collider2D>().bounds.min.y)
            {
                //We're falling!
                collision.collider.gameObject.SendMessage("Die");            
                GetComponent<CharacterMovement>().ForceJump(0.5f);
            }
        }
    }
}
