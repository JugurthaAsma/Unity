using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

/*
    public LevelBar healthBar;
    public float healthDamage;
    public LevelBar sleepBar;
    public float sleepDamage;
    public LevelBar foodBar;
    public float foodDamage;
    public LevelBar energyBar;
    public float energyDamage;
    public LevelBar powerBar;
    public float powerDamage;
*/
    Text playerMessage;
    Queue<string> messageQueue;
    public LevelBar[] levelBars;
    

    // Start is called before the first frame update
    void Start()
    {
        //LevelBar[] levelBars = { healthBar, sleepBar, foodBar, energyBar, powerBar };
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
        foreach (LevelBar levelBar in levelBars)
        {
            levelBar.TakeDamage();
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
/*
    void checkHealthLevel()
    {
        if (healthBar.IsMediumLevel())
        {
            //Debug.Log("healthBar.IsMediumLevel()");
            playerMessage.text = "I am healthy";
        } 
        else if (healthBar.IsLowLevel())
        {
            //Debug.Log("healthBar.IsLowLevel()");
            playerMessage.text = "I am sick";
        }
    }

    void checkSleepLevel()
    {
        if (sleepBar.IsMediumLevel())
        {
            //Debug.Log("sleepBar.IsMediumLevel()");
            playerMessage.text = "I am rested";
        }
        else if (sleepBar.IsLowLevel())
        {
            //Debug.Log("sleepBar.IsLowLevel()");
            playerMessage.text = "I am tired";
        }
    }

    void checkFoodLevel()
    {
        if (foodBar.IsMediumLevel())
        {
            //Debug.Log("foodBar.IsMediumLevel()");
            playerMessage.text = "I am full";
        }
        else if (foodBar.IsLowLevel())
        {
            //Debug.Log("foodBar.IsLowLevel()");
            playerMessage.text = "I am hungry";
        }
    }

    void checkEnergyLevel()
    {
        if (energyBar.IsMediumLevel())
        {
            //Debug.Log("energyBar.IsMediumLevel()");
            playerMessage.text = "I am energetic";
        }
        else if (energyBar.IsLowLevel())
        {
            //Debug.Log("energyBar.IsLowLevel()");
            playerMessage.text = "I am tired";
        }
    }

    void checkPowerLevel()
    {
        if (powerBar.IsMediumLevel())
        {
            //Debug.Log("powerBar.IsMediumLevel()");
            playerMessage.text = "I am strong";
        }
        else if (powerBar.IsLowLevel())
        {
            //Debug.Log("powerBar.IsLowLevel()");
            playerMessage.text = "I am weak";
        }
    }
*/
    void CheckLevelBar(LevelBar levelBar, string mediumMessage, string lowMessage)
    {
        if (levelBar.IsMediumLevel())
        {
            messageQueue.Enqueue(mediumMessage);
        }
        else if (levelBar.IsLowLevel())
        {
            messageQueue.Enqueue(lowMessage);
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
}
