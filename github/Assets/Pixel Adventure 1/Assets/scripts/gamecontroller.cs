using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamecontroller : MonoBehaviour
{

    public int totalScore;
    public TextMeshProUGUI scoreText;

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

}
