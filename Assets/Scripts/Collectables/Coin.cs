using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : Collectable
{

    public int Amount = 10;

    public Coin()
    {

    }

    // Use this for initialization
    protected override void Start () {
        base.Start();

	}

    // Update is called once per frame
    protected override void Update () {
        base.Update();

    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(triggerBy))
        {
            collision.gameObject.SendMessage("AddMoney", Amount);
        }
        base.OnCollisionEnter2D(collision);
    }
}
