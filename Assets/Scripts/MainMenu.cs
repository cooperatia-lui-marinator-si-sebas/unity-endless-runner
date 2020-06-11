using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MainMenu : MonoBehaviour
{
    public Player1 player;

    public ScoreManager highscore;

    private void Update()
    {
        highscore.highscoreDisplay.text = highscore.highscore.ToString();
        
    }

    
    public void PLayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}
