using UnityEngine;
using UnityEngine.Events;

public class ClickInteraction : MonoBehaviour
{
    public UnityEvent clicked;

    private Renderer _renderer;

    private bool insideTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        clicked.Invoke();
    }
}
