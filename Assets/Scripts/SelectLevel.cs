using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    


    
        public void Easy()
        {
            SceneManager.LoadScene(2);
        }
        
        public void Medium()
        {
        SceneManager.LoadScene(4);
        }

       public void Hard()
    {
        SceneManager.LoadScene(6);
    }


    
}
