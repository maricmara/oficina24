using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour
{

    public int totalScore;
    public TextMeshProUGUI scoreText;

    public GameObject gameOver;

    public static gamecontroller instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdatescoreText()
    {
        scoreText.text = totalScore.ToString();

    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);

    }

    public void RestartGame(string faseName)
    {
        SceneManager.LoadScene(faseName);

    }

}
