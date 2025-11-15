using UnityEngine;
using UnityEngine.Events;

public class FeedInteraction : MonoBehaviour
{
    public UnityEvent clicked;

    public FeedBar feedBar;
    public Pigeon pigeon;

    public float feedGain;

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        clicked.Invoke();
        pigeon.GainFeed(feedGain);
    }

}