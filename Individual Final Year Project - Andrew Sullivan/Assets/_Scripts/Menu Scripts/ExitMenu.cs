using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
    public void ExitClicked()
    {
        Application.Quit();
    }

    public void RestartClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
