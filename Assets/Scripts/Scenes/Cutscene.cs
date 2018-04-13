using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour {

    public string LevelScene;
    
    // Use this for initialization
	void Start () {
        // While we don't have any cutscene...
        SceneManager.LoadScene(LevelScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
