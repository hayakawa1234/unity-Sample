using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;

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
        Debug.Log("UI");
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    void Update()
    {
        Debug.Log("UI2");
        scoreText.GetComponent<Text>().text = "score:" + score.ToString("D4");  
    }
}
