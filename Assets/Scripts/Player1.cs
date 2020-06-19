using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{

    public float speed;
    public float maxY;
    public float minY;

    public float Yincrement;
    private Vector2 targetPos;

    public int health = 3;

    public GameObject effect;

    private Shake shake;
    public Text healthDisplay;

    public GameObject gameOver;

    public ScoreManager score;



    Scene currentScene;
    string sceneName;
    int gameOverBuildIndex;


    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Game":
                gameOverBuildIndex = 3;
                break;
            case "Game3":
                gameOverBuildIndex = 5;
                break;
        }

    }

    void Update()
    {
        if (healthDisplay)
        {
            healthDisplay.text = health.ToString();  //NullReferenceException
        }
        else
        {
            Debug.Log("NullReferenceException");
        }

        GoToGameOverScene();
    }

    private void GoToGameOverScene()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(gameOverBuildIndex);
            gameOver.SetActive(true);
            Destroy(gameObject);

        }
    }

    public void OnUpButtonPress()
    {
        if (transform.position.y < maxY)
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
    }

    public void OnDownButtonPress()
    {
        if (transform.position.y > minY)
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }
    }
}
