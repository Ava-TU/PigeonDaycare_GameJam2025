using UnityEngine;

public class Pigeon : MonoBehaviour
{
    public int maxHappy = 100;
    public int currentHappy;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHappy -= damage;

        if (currentHappy < 0)
        {
            currentHappy = 0;
        }

        happyBar.SetHappy(currentHappy);
    }
}
