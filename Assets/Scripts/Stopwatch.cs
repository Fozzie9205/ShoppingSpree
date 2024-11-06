using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class StopWatch : MonoBehaviour
{
    public bool stopwatchActive = false;
    public float currentTime;
    public TMP_Text currentTimeText;
    public TMP_Text endScore;

    public GameObject lastItem;

    void Start()
    {
        currentTime = 0f; //sets time scale to 0
    }

    void Update()
    {
        if (stopwatchActive == true) //If stop watch active, add time in format written
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
        endScore.text = time.ToString(@"mm\:ss\:fff");

        if (lastItem == null) //If last item destroyed, disable stop watch
        {
            stopwatchActive = false;
        }
    }
}
