using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int MaxTime = 60;
    public int CurrentScore = 0;
    public ScoreGui _Scoregui;
    //public SceneLoader _sceneLoader;

    public void CoinsCollected(int amount)
    {
        if (_Scoregui == null)
        {
            Debug.LogWarning("Missing SCORE GUI, please make sure to hook the correct TM_Text.");
            return;
        }

        _Scoregui.UpdateScore(CurrentScore);

        //if (CurrentScore >= MaxTime && _sceneLoader != null)
        //{
        //    SceneManager.LoadScene("MainMenu");
        //}

        CurrentScore += amount;
        Debug.Log("Current score = " + CurrentScore);
        //update the score
    }
    
}
