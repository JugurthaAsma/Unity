using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

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

    // Start is called before the first frame update
    void Start()
    {
        /*
        healthBar.SetMaxLevel(100);
        sleepBar.SetMaxLevel(100);
        foodBar.SetMaxLevel(100);
        energyBar.SetMaxLevel(100);
        powerBar.SetMaxLevel(100);
        */
    }

    // Update is called once per frame
    void Update()
    {
        TakeTimeDamage();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // heal every level bar by 10
            healthBar.heal(10);
            sleepBar.heal(10);
            foodBar.heal(10);
            energyBar.heal(10);
            powerBar.heal(10);
        }

        
        
    }

    public void TakeTimeDamage()
    {
        // each level bar takes it's damage
        healthBar.TakeDamage(healthDamage);
        sleepBar.TakeDamage(sleepDamage);
        foodBar.TakeDamage(foodDamage);
        energyBar.TakeDamage(energyDamage);
        powerBar.TakeDamage(powerDamage);

    }
}
