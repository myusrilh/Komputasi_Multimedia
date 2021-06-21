using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(string level) {
        level = "UTS";
        SceneManager.LoadScene(level);
        // Application.LoadLevel(1);
    }

    public void NextLevel(string level){
        level = "level2";
        SceneManager.LoadScene(level);
    }

    public void BackToMenu(string level){
        level = "MainMenu";
        SceneManager.LoadScene(level);
    }

    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
