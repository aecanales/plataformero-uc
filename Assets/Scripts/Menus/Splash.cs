using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

    public string MainMenuScene;

    private SpriteRenderer spriteRenderer;
    private List<float> fadeTiming = new List<float> {1.0f, 2.0f, 1.0f};
    private int fadeState = 0;  // 0-Fade In, 1-Wait, 2-Fade Out 

	// Use this for initialization
	void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.material.color = new Color(1, 1, 1, 0); 
	}
	
	// Update is called once per frame
	void Update () {
        switch (fadeState) {
            case 0:  // Fade in
                if (spriteRenderer.material.color.a < 1)
                {
                    float new_alpha = Mathf.Clamp(spriteRenderer.material.color.a + (1 / fadeTiming[0]) * Time.deltaTime, 0, 1);
                    spriteRenderer.material.color = new Color(1, 1, 1, new_alpha);
                }
                else
                {
                    fadeState = 1;
                    StartCoroutine(waitBetweenFades());
                }
                break;
            case 2:  // Fade out
                if (spriteRenderer.material.color.a > 0)
                {
                    float new_alpha = Mathf.Clamp(spriteRenderer.material.color.a - (1 / fadeTiming[2]) * Time.deltaTime, 0, 1);
                    spriteRenderer.material.color = new Color(1, 1, 1, new_alpha);
                }
                else
                {
                    SceneManager.LoadScene(MainMenuScene);
                }
                break;
        }
	}

    IEnumerator waitBetweenFades() {
        yield return new WaitForSeconds(fadeTiming[1]);
        fadeState = 2;
    }

}
