using UnityEngine;
using UnityEngine.UI;

public class HappyBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHappy(int maxHappy)
    {
        slider.maxValue = maxHappy;
        slider.value = maxHappy;
    }

    public void SetHappy(int happy)
    {
        slider.value = happy;
    }
}
