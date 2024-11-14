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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp -= 10;
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            hp += 10;
        }

        healthBar.SetHealth(hp);
    }
}