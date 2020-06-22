using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBotton : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(0);
    }

    public void SelectLevelBUton()
    {
        SceneManager.LoadScene(1);
    }
}
