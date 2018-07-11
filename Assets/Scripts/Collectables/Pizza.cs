using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Collectable{ 


    public Pizza()
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
            // Do something
        }
        base.OnCollisionEnter2D(collision);
    }
}
