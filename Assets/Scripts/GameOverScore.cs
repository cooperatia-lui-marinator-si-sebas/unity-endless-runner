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
            case "GameOver3":
                if (PlayerPrefs.HasKey("HighScoreScene4"))
                {
                    gameOverHighScore = PlayerPrefs.GetInt("HighScoreScene4");
                    gameOverHighScoreDisplay.text = gameOverHighScore.ToString();
                }
                break;
        }

    }

    

}
