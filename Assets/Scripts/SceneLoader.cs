using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void GoHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void WinGame()
    {
        SceneManager.LoadScene("WinGame");
    }
}
