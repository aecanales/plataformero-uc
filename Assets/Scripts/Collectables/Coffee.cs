using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : Collectable {

    public int amount = 1;

    public Coffee()
    {

    }

    protected override void Start()
    {
        base.Start();

    }
    protected override void Update()
    {
        base.Update();

    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(triggerBy))
        {
            collision.gameObject.SendMessage("lifeUp", amount);
        }
        base.OnCollisionEnter2D(collision);
    }
}
