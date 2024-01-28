using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
    public int bossHealth = 100; // Set the boss health in the Inspector
    public int hitsToDestroy = 3; // Number of hits required to destroy the FinalBoss
    private int currentHits = 0; // Current number of hits
    public Health playerHealth; // Reference to the player's health script

    void Start()
    {
        // Assuming the player's health script is on the same GameObject as the player
        playerHealth = FindObjectOfType<Health>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            // Check if the player's health is at least 20
            if (playerHealth.currentHealth >= 20)
            {
                // Increase the hit count
               // currentHits++;

                // Check if the FinalBoss should be destroyed
                //if (currentHits >= hitsToDestroy)
                //{
                    Destroy(gameObject); // Destroy the FinalBoss
                //}
            }
            else
            {
                Destroy(other.gameObject); // Destroy the player
                // You may want to add other logic here, like game over or respawn
            }
        }
    }
}
