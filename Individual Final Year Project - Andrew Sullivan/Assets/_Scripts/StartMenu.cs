using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void PlayClicked()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitClicked()
    {
        Application.Quit();
    }
}
