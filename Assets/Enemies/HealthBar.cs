using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthBar : MonoBehaviour
{
    public Slider slider; 
    public Gradient gradient; 
    public Image fill; 
    //Setting Max value for health so we don't have change it inside Unity Editor 

    public void SetMaxHealth(int health) { 
        slider.maxValue = health; 
        slider.value = health; //start at max health 

        fill.color = gradient.Evaluate(1f); 

    }

    //Change health from Slider inside HealthBar 
    public void SetHealth(int health) { 
        slider.value = health; 

        fill.color = gradient.Evaluate(slider.normalizedValue); 
    }
}

