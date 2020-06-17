using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void OnButtonPress() 
    {
            Debug.Log("QUIT!");
            Application.Quit();   
    }

    public void Quitgame1()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
