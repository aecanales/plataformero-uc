using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{

    public string LevelScene;

    // Update is called once per frame
    private void Update()
    {
        // Thanks to shanta3220 for the code.
        // https://answers.unity.com/questions/1065971/how-do-you-detect-a-mouse-button-click-on-a-game-o.html?childToView=1598105#comment-1598105
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));

            if (hitCollider != null)
            {
                Gender.Sex = hitCollider.gameObject.name;
                SceneManager.LoadScene(LevelScene);
            }
        }
    }
}
