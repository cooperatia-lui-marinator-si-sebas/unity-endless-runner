using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;



    public int score;
    public int highscore;
    public int gameOverScore;

    public Text scoreDisplay;
    public Text highscoreDisplay;
    public Text gameOverScoreDisplay;

    public Scene currentScene;
    public string sceneName;


    public Player1 player;


    private void Start()
    {
        ResetScore();
        
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Game":
                if (PlayerPrefs.HasKey("HighScoreScene2"))
                {
                    Debug.Log(PlayerPrefs.GetInt("HighScoreScene2"));
                    highscore = PlayerPrefs.GetInt("HighScoreScene2");
                    highscoreDisplay.text = highscore.ToString();
                }
                break;
            /*case "Game2":
                if (PlayerPrefs.HasKey("HighScoreScene4"))
                {
                    highscore = PlayerPrefs.GetInt("HighScoreScene4");
                    highscoreDisplay.text = highscore.ToString();
                }
                break;*/
            case "Game3":
                if (PlayerPrefs.HasKey("HighScoreScene4"))
                {
                    highscore = PlayerPrefs.GetInt("HighScoreScene4");
                    highscoreDisplay.text = highscore.ToString();
                }
                break;
        }

    }

    private void Awake()
    {
        ResetScore();

        instance = this;
        

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
        scoreDisplay.text = score.ToString();
        UpdateHighscore();

       
        PlayerPrefs.SetInt("Score", score);
        
    }
    
    
 

    public void UpdateHighscore()
    {

        // Check the scene name as a conditional.
         switch (sceneName)
         {
         case "Game":
                if (score >= highscore)
                {
                    highscore = score;
                    highscoreDisplay.text = highscore.ToString();
                    PlayerPrefs.SetInt("HighScoreScene2", highscore);
                }
                break;
         /*case "Game2":
                if (score >= highscore)
                {
                    highscore = score;
                    highscoreDisplay.text = highscore.ToString();
                    PlayerPrefs.SetInt("HighScoreScene4", highscore);
                }
                break;*/
         case "Game3":
                if (score >= highscore)
                {
                    highscore = score;
                    highscoreDisplay.text = highscore.ToString();
                    PlayerPrefs.SetInt("HighScoreScene4", highscore);
                }
                break;

         } 
    }

   
    

    public void ResetScore()
    {
        score = 0;
    }
}
