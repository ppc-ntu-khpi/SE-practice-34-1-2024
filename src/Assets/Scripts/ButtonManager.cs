using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(int numScene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(numScene);
    }

    public void ShowPanel(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void HidePanel(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void PauseGame(PauseButton pauseButton)
    {
        pauseButton.PauseGame();
    }

    // Update is called once per frame
    public void ResumeGame(ResumeButton resumeButton)
    {
        resumeButton.ResumeGame();
    }
}
