using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public GameObject HowToPlay;
    public bool isEnable = true;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void OnClick()
    {
        isEnable = !isEnable;
        HowToPlay.SetActive(isEnable);
    }
   
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
