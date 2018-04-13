using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string CutsceneScene;

    void StartGame()
    { SceneManager.LoadScene(CutsceneScene); }
}
