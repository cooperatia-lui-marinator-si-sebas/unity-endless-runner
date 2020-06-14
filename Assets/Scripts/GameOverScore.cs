using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public int gameOverScore;
    public Text gameOverScoreDisplay;

    public ScoreManager instance;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScore = PlayerPrefs.GetInt("Score");
        gameOverScoreDisplay.text = gameOverScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

}
