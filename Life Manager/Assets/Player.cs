using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float maxhealth = 100;
    public float currentHealth;
    public LevelBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxhealth;
        healthBar.setMaxLevel(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        TakeDamage(0.1f);
        
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.setLevel(currentHealth);
    }
}
