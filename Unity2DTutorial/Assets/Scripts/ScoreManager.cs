using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    public Text scoreDisplay;

    void Start()
    {
        scoreDisplay.text = "0";
    }

    public void increaseScore(int moreScore)
    {
        score += moreScore;
        scoreDisplay.text = score.ToString();
    }
}
