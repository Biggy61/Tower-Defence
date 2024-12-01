using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTower : MonoBehaviour
{
    public int hp;
    public int maxHealth = 100;
    public EnemyHealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

        healthBar.SetHealth(hp);
    }
}