using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
