using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public string sceneName;

    public void PlayGame() 
    { 
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGAme()
    {
      Application.Quit();
    }
}
