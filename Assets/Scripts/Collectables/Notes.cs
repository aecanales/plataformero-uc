using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : Collectable {
    public float time = 5.0f;
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
            collision.gameObject.SendMessage("ActivateAbility", time);
        }
        base.OnTriggerEnter2D(collision);
    }
}
