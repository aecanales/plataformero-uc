using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public string CutsceneScene;

    public GameObject StartGameButton;
    public GameObject OpenCreditsButton;

    public Text Credits;
    public GameObject CloseCreditsButton;

    void StartGame()
    { SceneManager.LoadScene(CutsceneScene); }

    void ShowCredits()
    {
        StartGameButton.SetActive(false);
        OpenCreditsButton.SetActive(false);

        Credits.gameObject.SetActive(true);
        CloseCreditsButton.SetActive(true);
    }

    void HideCredits()
    {
        StartGameButton.SetActive(true);
        OpenCreditsButton.SetActive(true);

        Credits.gameObject.SetActive(false);
        CloseCreditsButton.SetActive(false);
    }
}
