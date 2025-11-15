using UnityEngine;
using UnityEngine.Events;

public class CleanInteraction : MonoBehaviour
{
    public UnityEvent clicked;

    public CleanBar cleanBar;
    public Pigeon pigeon;

    public float cleanGain;

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        clicked.Invoke();
        pigeon.GainClean(cleanGain);
    }

}
