using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Stopwatch : MonoBehaviour
{
    public bool stopwatchActive = false;
    float currentTime;
    public int startMinutes;
    public TMP_Text currentTimeText;

    void Start()
    {
        currentTime = startMinutes * 60f;
    }

    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <=0)
            {
                stopwatchActive = false;
                Start();
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }
}
