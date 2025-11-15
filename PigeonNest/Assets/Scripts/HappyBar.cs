using UnityEngine;
using UnityEngine.UI;

public class HappyBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHappy(float maxHappy)
    {
        slider.maxValue = maxHappy;
        slider.value = maxHappy;
    }

    public void SetHappy(float happy)
    {
        slider.value = happy;
    }
}
