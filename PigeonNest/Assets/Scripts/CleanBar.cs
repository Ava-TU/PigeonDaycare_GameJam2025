using UnityEngine;
using UnityEngine.UI;

public class CleanBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxClean(float maxClean)
    {
        slider.maxValue = maxClean;
        slider.value = maxClean;
    }

    public void SetClean(float clean)
    {
        slider.value = clean;
    }
}
