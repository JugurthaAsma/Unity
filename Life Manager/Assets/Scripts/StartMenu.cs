using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private void Update()
    {
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
        //Application.LoadLevel("Game");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
