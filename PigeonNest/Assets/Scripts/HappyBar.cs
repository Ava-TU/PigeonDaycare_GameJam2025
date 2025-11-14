using UnityEngine;
using UnityEngine.UI;

public class HappyBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHappy(int happy)
    {
        slider.maxValue = happy;
        slider.value = happy;
    }

    public void SetHappy(int happy)
    {
        slider.value = happy;
    }
}
