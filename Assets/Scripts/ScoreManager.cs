using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    public Text highscoreDisplay;
    public int highscore;

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
                    score++;
                    Debug.Log(score);

                }
            }
        }
    }
    
}
