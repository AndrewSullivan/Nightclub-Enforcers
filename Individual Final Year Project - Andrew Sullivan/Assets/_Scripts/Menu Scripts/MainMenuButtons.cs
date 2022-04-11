using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public void PlayClicked()
    {
        SceneManager.LoadScene("GameScene"); // Loads the scene named "GameScene".
    }

    public void ControlsClicked()
    {
        SceneManager.LoadScene("TutorialScene"); // Loads the scene named "TutorialScene".
    }

    public void ExitClicked()
    {
        Application.Quit(); // Closes the application.
    }
}
