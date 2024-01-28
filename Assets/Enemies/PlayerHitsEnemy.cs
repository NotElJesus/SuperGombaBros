using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitsEnemy : MonoBehaviour
{
    private Health playerHealth;

    void Start()
    {
        playerHealth = GetComponent<Health>(); // Assuming the Health script is on the same GameObject as this script
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        playerHealth.HandleCollisions(other);
    }
}

