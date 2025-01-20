using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int time = 0;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    public float scoreIncrease = 1f;
    private int score = 0;
    private int highScore = 0;

    private bool isGameOver = false;
    
    void Start()
    {
        InvokeRepeating("IncreaseScore", scoreIncrease, scoreIncrease);
    }

    void IncreaseScore()
    {
        if (isGameOver) return;

        score++;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameOver = true;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "High Score: " + highScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
