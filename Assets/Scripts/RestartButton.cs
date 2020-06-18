using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private void Start()
    {

    }

    public void OnButtonPressGameOver()
    {
        SceneManager.LoadScene(2);
    
    }
 /*   public void OnButtonPressGameOver2()
    {
        SceneManager.LoadScene(4);

    }*/
    public void OnButtonPressGameOver3()
    {
        SceneManager.LoadScene(4);

    }

/*    public void OnButtonPress1()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
     }*/

}