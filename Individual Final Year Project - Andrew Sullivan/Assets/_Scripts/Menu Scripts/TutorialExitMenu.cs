using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialExitMenu : MonoBehaviour
{
    public void ExitClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
