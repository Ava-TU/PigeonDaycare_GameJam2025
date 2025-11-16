using UnityEngine;

public class Pigeon : MonoBehaviour
{
    public float maxHappy = 100f;
    public float currentHappy;

    public float maxClean = 100f;
    public float currentClean;

    public float maxFeed = 100f;
    public float currentFeed;

    public HappyBar happyBar;
    public CleanBar cleanBar;
    public FeedBar feedBar;

    public ChangeSceneScript changeScene;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHappy = maxHappy;
        happyBar.SetMaxHappy(maxHappy);

        currentClean = maxClean;
        cleanBar.SetMaxClean(maxClean);

        currentFeed = maxFeed;
        feedBar.SetMaxFeed(maxFeed);
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

        currentFeed -= 6 * Time.deltaTime;
        if (currentFeed < 0)
        {
            currentFeed = 0;
        }
        feedBar.SetFeed(currentFeed);

        currentClean -= 6 * Time.deltaTime;
        if (currentClean < 0)
        {
            currentClean = 0;
        }
        cleanBar.SetClean(currentClean);

        if (currentHappy <= 0 || currentClean <= 0 || currentFeed <= 0)
        {
            changeScene.ChangeScene();
        }
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

    public void TakeClean(float damage)
    {
        currentClean -= damage;

        if (currentClean < 0)
        {
            currentClean = 0;
        }

        cleanBar.SetClean(currentClean);
    }

    public void TakeFeed(float damage)
    {
        currentFeed -= damage;

        if (currentFeed < 0)
        {
            currentFeed = 0;
        }

        feedBar.SetFeed(currentFeed);
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

    public void GainClean(float gain)
    {
        currentClean += gain;

        if (currentClean > maxClean)
        {
            currentClean = maxClean;
        }

        cleanBar.SetClean(currentClean);
    }

    public void GainFeed(float gain)
    {
        currentFeed += gain;

        if (currentFeed > maxFeed)
        {
            currentFeed = maxFeed;
        }

        feedBar.SetFeed(currentFeed);
    }

}
