using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : Colectable {

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
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(triggerBy))
        {
            collision.gameObject.SendMessage("lifeUp", amount);
        }
        base.OnTriggerEnter2D(collision);
    }
}
