using UnityEngine;
using UnityEngine.UI;

public class FeedBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxFeed(float maxFeed)
    {
        slider.maxValue = maxFeed;
        slider.value = maxFeed;
    }

    public void SetFeed(float feed)
    {
        slider.value = feed;
    }
}
