using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreGui : SceneLoader
{
    public TMP_Text ScoreUI;

    public void UpdateScore(int score)
    {
        if (ScoreUI == null)
            return;

        ScoreUI.text = "SCORE: " + score.ToString();

        if (score >= 10000)
        {
            GoHome();
        }
    }
}
