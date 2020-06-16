using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    


    
        public void Easy()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
        public void Medium()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }

       public void Hard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }


    
}
