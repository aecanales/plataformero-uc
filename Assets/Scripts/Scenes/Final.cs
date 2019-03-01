using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour {

    public string MenuScene;

    // Use this for initialization
    void Start () {
        StartCoroutine(LoadMenu());
	}
	
	// Update is called once per frame
	IEnumerator LoadMenu () {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(MenuScene);
	}
}
