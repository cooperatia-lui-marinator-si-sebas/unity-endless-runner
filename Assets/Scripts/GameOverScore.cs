using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScore : MonoBehaviour
{
    public int gameOverScore;
    public Text gameOverScoreDisplay;

    public int gameOverHighScore;
    public Text gameOverHighScoreDisplay;

    public Scene currentScene;
    public string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        gameOverScore = PlayerPrefs.GetInt("Score");
        gameOverScoreDisplay.text = gameOverScore.ToString();

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        switch (sceneName)
        {
            case "GameOver":
                if (PlayerPrefs.HasKey("HighScoreScene2"))
                {
                    gameOverHighScore = PlayerPrefs.GetInt("HighScoreScene2");
                    gameOverHighScoreDisplay.text = gameOverHighScore.ToString();
                }
                break;
            /*case "Game2":
                if (PlayerPrefs.HasKey("HighScoreScene4"))
                {
                    highscore = PlayerPrefs.GetInt("HighScoreScene4");
                    highscoreDisplay.text = highscore.ToString();
                }
                break;*/
            case "GameOver3":
                if (PlayerPrefs.HasKey("HighScoreScene4"))
                {
                    gameOverHighScore = PlayerPrefs.GetInt("HighScoreScene4");
                    gameOverHighScoreDisplay.text = gameOverHighScore.ToString();
                }
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

}
