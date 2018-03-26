using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moneda : Colectable
{

    public int Amount = 10;

    public Moneda()
    {

    }

    // Use this for initialization
    void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}
}
