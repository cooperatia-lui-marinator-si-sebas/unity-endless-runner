using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;        
    }

    public int score;
    public int highscore;

    public Text scoreDisplay;
    public Text highscoreDisplay;
    


    public Player1 player;
 
    private void Update()
    {
        scoreDisplay.text = score.ToString();

        if (score > highscore) 
        {
            highscore = score;
        }
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if(player.health > 0)
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
    }

    public void UpdateHighscore()
    {
        if (score > highscore)
        {
            highscore = score;
            highscoreDisplay.text = highscore.ToString();        }
    }

    public void ResetScore()
    {
        score = 0;
    }
}
