using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Hitpoints : MonoBehaviour
{
    public int maxHealth = 100;
    public int currHealth;
    public slider healthBar;
    void Start()
    {
        currHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(1);
        }
    }

    void TakeDamage(int dmg) {
        currHealth -= dmg;
        healthBar.CurrHealth(currHealth);
    }
}
