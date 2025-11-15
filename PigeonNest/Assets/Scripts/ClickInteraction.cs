using UnityEngine;
using UnityEngine.Events;

public class ClickInteraction : MonoBehaviour
{
    public UnityEvent clicked;

    public HappyBar happyBar;
    public Pigeon pigeon;

    public float happyGain;

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        clicked.Invoke();
        pigeon.GainHappy(happyGain);
    }

}
