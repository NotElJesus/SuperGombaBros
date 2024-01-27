using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 150;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // You can handle other player input or events here if needed
    }

    // Call this function to apply damage and handle collisions with obstacles
    public void HandleCollisions(Collision2D collision)
    {
        if (collision.transform.tag == "Obstacle" || collision.transform.tag == "Player")
        {
            TakeDamage(10);
            Destroy(collision.gameObject); // Destroy the obstacle
            // Add any other logic you need, like pausing or handling the jump over the obstacle
        }
    }

    void TakeDamage(int damage)
    {

        if (currentHealth == 10) { 
            Destroy(gameObject); 
        }
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}

