using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Scene 1");
    }

    public void options()
    {

    }

    public void exitGame()
    {
        Application.Quit();
    }
}
