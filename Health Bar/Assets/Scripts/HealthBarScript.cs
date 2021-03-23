using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;

    public void TotalHealth (int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SHealth (int health)
    {
        slider.value = health;
    }


}
