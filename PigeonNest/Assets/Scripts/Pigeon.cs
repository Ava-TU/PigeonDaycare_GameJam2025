using UnityEngine;

public class Pigeon : MonoBehaviour
{
    public float maxHappy = 100f;
    public float currentHappy;

    public HappyBar happyBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHappy = maxHappy;
        happyBar.SetMaxHappy(maxHappy);
    }

    // Update is called once per frame
    void Update()
    {
       //This will deplenish the meters overtime
       currentHappy -= 6 * Time.deltaTime;
        if (currentHappy < 0)
        {
            currentHappy = 0;
        }
        happyBar.SetHappy(currentHappy);
    }

    public void TakeHappy(float damage)
    {
        currentHappy -= damage;

        if (currentHappy < 0)
        {
            currentHappy = 0;
        }

        happyBar.SetHappy(currentHappy);
    }
    
    public void GainHappy(float gain)
    {
        currentHappy += gain;

        if (currentHappy > maxHappy)
        {
            currentHappy = maxHappy;
        }

        happyBar.SetHappy(currentHappy);
    }

}
