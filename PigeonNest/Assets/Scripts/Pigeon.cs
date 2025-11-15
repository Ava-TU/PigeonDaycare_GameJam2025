using UnityEngine;

public class Pigeon : MonoBehaviour
{
    public float maxMeter = 100f;
    public float currentMeter;

    public MeterBar meterBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentMeter = maxMeter;
        meterBar.SetMaxMeter(maxMeter);
    }

    // Update is called once per frame
    void Update()
    {
       //This will deplenish the meters overtime
       currentMeter -= 6 * Time.deltaTime;
        if (currentMeter < 0)
        {
            currentMeter = 0;
        }
        meterBar.SetMeter(currentMeter);
    }

    public void TakeMeter(float damage)
    {
        currentMeter -= damage;

        if (currentMeter < 0)
        {
            currentMeter = 0;
        }

        meterBar.SetMeter(currentMeter);
    }
    
    public void GainMeter(float gain)
    {
        currentMeter += gain;

        if (currentMeter > maxMeter)
        {
            currentMeter = maxMeter;
        }

        meterBar.SetMeter(currentMeter);
    }

}
