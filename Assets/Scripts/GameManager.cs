using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 0;

    public TextMeshProUGUI livesText;
    public TextMeshProUGUI ScoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    void Update()
    {
        livesText.text = "Lives: " + lives;
        ScoreText.text = "Score: " + score;
    }
}
