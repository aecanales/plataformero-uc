using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitcher : MonoBehaviour {

    public RuntimeAnimatorController femaleAnimations;
    public RuntimeAnimatorController maleAnimations;

    private bool isFemale = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)) {
            if (isFemale)
                GetComponent<Animator>().runtimeAnimatorController = maleAnimations;
            else
                GetComponent<Animator>().runtimeAnimatorController = femaleAnimations;
            isFemale = !isFemale;
        }
		
	}
}
