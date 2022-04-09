using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public static bool isGamePaused = false;

    public GameObject PauseMenu = null;


    private void Start()
    {
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {
        
        //si j'appuie sur echap 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void ResumeGame()
    {
        if (PauseMenu != null)
        {
            PauseMenu.SetActive(false);
            //le temps se relance
            Time.timeScale = 1f;
            isGamePaused = false;
        }

    }

    void PauseGame()
    {   
        if (PauseMenu != null)
        {
            PauseMenu.SetActive(true);
            //le temps s'arrete
            Time.timeScale = 0f;
            isGamePaused = true;
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
