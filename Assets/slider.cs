using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Slider healthBar;

    public void CurrHealth(int health) { 
        healthBar.value = health;
    }

    public void SetMaxHealth(int health) { 
        healthBar.maxValue = health;
        healthBar.value = health;
    }
}
