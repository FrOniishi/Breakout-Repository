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
        if (pauseMenuUI.activeInHierarchy) optionsMenuUI.SetActive(false);
    }

    public void HidePauseMenu ()
    {
        if (pauseMenuUI != null ) pauseMenuUI.SetActive(false);
    }

    public void ShowOptionsMenu ()
    {
        optionsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
