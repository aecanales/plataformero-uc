using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : Collectable {

    public Notes()
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
        if (collision.gameObject.CompareTag(triggerBy)) {
            collision.gameObject.SendMessage("ActivateAbility", 5.0f);
        }
        base.OnTriggerEnter2D(collision);
    }
}
