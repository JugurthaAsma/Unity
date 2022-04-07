using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public static bool isGamePaused = false;

    [SerializeField] GameObject PauseMenu;


    private void Start()
    {
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {

        
        //si jappuie sur espace 
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
        PauseMenu.SetActive(false);
        //le temps reste le meme
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void PauseGame()
    {   
        PauseMenu.SetActive(true);
        //le temps sarrete
        Time.timeScale = 0f;
        isGamePaused = true;
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
