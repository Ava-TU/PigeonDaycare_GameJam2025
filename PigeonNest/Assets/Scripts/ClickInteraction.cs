using UnityEngine;
using UnityEngine.Events;

public class ClickInteraction : MonoBehaviour
{
    public UnityEvent clicked;

    public MeterBar meterBar;
    public Pigeon pigeon;

    public float meterGain;

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        clicked.Invoke();
        pigeon.GainMeter(meterGain);
    }

}
