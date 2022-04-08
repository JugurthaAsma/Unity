using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    Text playerMessage;
    Queue<string> messageQueue;
    int indexOfMainLevelBar = 0;
    public LevelBar[] levelBars;

    
    

    // Start is called before the first frame update
    void Start()
    {
        // get text child gameobject
        playerMessage = transform.Find("PlayerMessage").GetComponent<Text>();
        messageQueue = new Queue<string>();
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        TakeTimeDamage();
        CheckLevels();
        DisplayMessage();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (LevelBar levelBar in levelBars)
            {
                levelBar.Heal(10);
            }
        }    
    }
    public void TakeTimeDamage()
    {
        // check if the main level bar is not empty (if the player is not dead)
        if (levelBars[indexOfMainLevelBar].getCurrentLevel() > 0)
        {
            // take time damage
            foreach (LevelBar levelBar in levelBars)
            {
                levelBar.TakeDamage();
            }
        }
        else
        {
            // Game Over (player is dead)
            GameOver();
        }
        
    }
    public void CheckLevels()
    {
        // iterate through all level bars
        foreach (LevelBar levelBar in levelBars)
        {
            CheckLevelBar(levelBar, levelBar.mediumMessage, levelBar.lowMessage);
        }
    }
    void CheckLevelBar(LevelBar levelBar, string mediumMessage, string lowMessage)
    {
        if (levelBar.IsMediumLevel())
        {
            messageQueue.Enqueue(mediumMessage);
            levelBars[indexOfMainLevelBar].TakeDamage(levelBar.medieumDamageEffect);
        }
        else if (levelBar.IsLowLevel())
        {
            messageQueue.Enqueue(lowMessage);
            Debug.Log(levelBars[indexOfMainLevelBar]);
            levelBars[indexOfMainLevelBar].TakeDamage(levelBar.lowDamageEffect);
        }
    }
    void DisplayMessage()
    {
        if (messageQueue.Count > 0)
        {
            string message = messageQueue.Dequeue();
            Debug.Log(message);
            // if the queue not contains the message, then display it
            if (!messageQueue.Contains(message))
            {
                playerMessage.text = message;
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
