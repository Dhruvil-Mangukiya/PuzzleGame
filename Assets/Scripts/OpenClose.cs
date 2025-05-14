using UnityEngine;
using UnityEngine.UI;

public class OpenCloseScript : MonoBehaviour
{
    public GameObject Homescreen;
    public Button homeButton;

    public void HomeButton()
    {
        Homescreen.SetActive(true);
        Time.timeScale = 0f;
        GameManager_script.Instance.isGamePaused = true;
        homeButton.interactable = false;
        

        // bool isActive = objectToToggle.activeSelf;
        // objectToToggle.SetActive(!isActive);

        // if (isActive)
        // {
        //     Time.timeScale = 1f;
        //     GameManager_script.Instance.isGamePaused = false;
        // }
        // else
        // {
        //     Time.timeScale = 0f;
        //     GameManager_script.Instance.isGamePaused = true;
        // }
    }

    public void ResumeButton()
    {
        Homescreen.SetActive(false);
        Time.timeScale = 1f;
        GameManager_script.Instance.isGamePaused = false;
        homeButton.interactable = true;
    }
}

