using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public Text scoreText;
    public Text ballCountText;
    public GameObject winPanel;

    // Keep track of our player score
    private int score = 0;
    // Keep track of available balls
    public int ballCount = 3;

    public bool isWon = false;
    public bool isFailed = false;


    void Start()
    {
        ballCountText.text = ballCount.ToString();
    }


    public void AddScore(int scoreChange)
    {
        score = score + scoreChange;
        scoreText.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }

    public bool CanGetNewBall()
    {
        if(ballCount > 0)
        {
            ballCount = ballCount - 1;
            ballCountText.text = ballCount.ToString();
            return true;
        }

        return false;
    }

    public void AddBall()
    {
        ballCount++;
        ballCountText.text = ballCount.ToString();
    }

    public void Win()
    {
        isWon = true;
        winPanel.SetActive(true);
    }


    public void Lose()
    {
        isFailed = true;
    }
}
