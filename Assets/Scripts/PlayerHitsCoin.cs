using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitsCoin : MonoBehaviour
{
    public CoinHealthBar coinbar;
    private int coins = 0;
    [SerializeField] private AudioSource audioSource;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Coin")
        {
            audioSource.Play();
            coins+= 10;
            Debug.Log("Coin Hit");
            coinbar.SetHealth(coins);
            Destroy(other.gameObject);
        }
    }
}

