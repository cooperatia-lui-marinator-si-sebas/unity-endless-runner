using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, PauseButon;

    public void Pause()
    {
        Pausemenu.SetActive(true);
        PauseButon.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Pausemenu.SetActive(false);
        PauseButon.SetActive(true);
        Time.timeScale = 1;
    }
}
