using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; 

public class CoinHealthBar : MonoBehaviour
{
    public int coinHealth;
    public Slider slider; 
    public Gradient gradient; 
    public Image fill; 
    public TextMeshProUGUI coinText;
    //Setting Max value for health so we don't have change it inside Unity Editor 
    public void SetMaxHealth() { 
        slider.maxValue = 150;
        slider.value = 0; //start at 0 health 
        fill.color = gradient.Evaluate(1f); 

    }

    //Change health from Slider inside HealthBar 
    public void SetHealth(int health) { 
        slider.value = health; 
        fill.color = gradient.Evaluate(slider.normalizedValue); 
    }
    public void UpdateHealth(int health)
    {
        coinHealth += health;
        SetHealth(coinHealth);
    }
    public void ShowHealth()
    {
        coinText.text = "Coins Collected: " + coinHealth/10;
        // Start coroutine to reset the text after 2 seconds
        StartCoroutine(ResetTextAfterDelay(2f));
    }

    IEnumerator ResetTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        // Reset the text value
        coinText.text = "";
    }

}


