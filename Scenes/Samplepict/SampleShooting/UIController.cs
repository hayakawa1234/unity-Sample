﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

    public void AddScore()
    {
        this.score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "score:" + score.ToString("D4");  
    }
}
