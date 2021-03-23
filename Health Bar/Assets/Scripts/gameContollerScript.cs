using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameContollerScript : MonoBehaviour
{
    private int maxHealth=100;
    private int currentHealth;

    HealthBarScript HealthBar;
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar = FindObjectOfType<HealthBarScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Press Space & your health bar take 10 damage
        {
            TDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.R)) // Press R & your health bar is full
        {
            currentHealth = 100;
            HealthBar.SHealth(currentHealth);
        }
    }
    private void TDamage(int damage)
    {
        currentHealth -= damage;
        HealthBar.SHealth(currentHealth);
    }
}
