using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Stats))]
public class DamageOnHit : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject spawnPoint;
    public HealthBar healthBar;
    public int maxHealth;
    public int currentHealth;
    private void Start()
    {
        Stats ourStats = GetComponent<Stats>();
        ourStats.currentHealth = ourStats.maxHealth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Stats ourStats = GetComponent<Stats>();
        Stats hitStats = collision.gameObject.GetComponent<Stats>();

        if (hitStats != null)
        {
            hitStats.currentHealth -= ourStats.attack - hitStats.defense;
            if (healthBar)
            {
                currentHealth -= hitStats.currentHealth;
                healthBar.SetHealth(currentHealth);
            }
            if (ourStats.currentHealth <= 0)
            {
                if (spawnPoint)
                {
                    gameManager.PositionPlayer();
                }
                gameObject.SetActive(false);
            }
        }
        
    }
}