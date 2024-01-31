using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinHealth : MonoBehaviour
{
    public int maxHealth = 150;
    public int currentHealth;
    public CoinHealthBar coinbar;
    public Entity entity; // Reference to the Entity script

    void Start()
    {
        currentHealth = maxHealth;
        coinbar.SetMaxHealth();
    }

    void Update()
    {
        // You can handle other player input or events here if needed
    }
}