using UnityEngine;
using UnityEngine.UI;

public class MeterBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxMeter(float maxMeter)
    {
        slider.maxValue = maxMeter;
        slider.value = maxMeter;
    }

    public void SetMeter(float meter)
    {
        slider.value = meter;
    }
}
