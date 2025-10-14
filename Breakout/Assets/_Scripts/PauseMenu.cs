using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;

    public void ShowPauseMenu ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        if (pauseMenuUI.activeInHierarchy) optionsMenuUI.SetActive(false);
    }

    public void HidePauseMenu ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowOptionsMenu ()
    {
        optionsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void HideOptionsMenu ()
    {
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
