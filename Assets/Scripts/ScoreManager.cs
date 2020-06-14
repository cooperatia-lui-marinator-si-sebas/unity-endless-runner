using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;



    public int score;
    public int highscore;
    public int gameOverScore;

    public Text scoreDisplay;
    public Text highscoreDisplay;
    public Text gameOverScoreDisplay;


    public Player1 player;
    private void Awake()
    {
        //ResetScore();

        instance = this;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
            highscoreDisplay.text = highscore.ToString();
        }
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (player.health > 0)
        {
            if (other.CompareTag("Enemy"))
            {
                {
                    AddScore();

                }
            }
        }
    }


    public void AddScore()
    {
        score++;
        UpdateHighscore();

        scoreDisplay.text = score.ToString();
 

       
        PlayerPrefs.SetInt("Score", score);
        
    }

    public void UpdateHighscore()
    {
        if (score >= highscore)
        {
            highscore = score;
            highscoreDisplay.text = highscore.ToString();
        }

        PlayerPrefs.SetInt("HighScore", highscore);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
