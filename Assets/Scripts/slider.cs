using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Slider omaslider;
    public void SetMaxHealth(float health)
    {
        omaslider.maxValue = health;
        omaslider.value = health;
    }
    public void SetHealth(float health)
    {
        omaslider.value = health;
    }
}
