using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class StopWatch : MonoBehaviour
{
    public static StopWatch Instance;

    public bool stopwatchActive = false;
    public float currentTime;
    public TMP_Text currentTimeText;
    public TMP_Text endScore;

    public TMP_Text highScore;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        currentTime = 0f; //sets time scale to 0
    }

    void Update()
    {
        if (stopwatchActive) //If stop watch active, add time in format written
        {
            currentTime += Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
        endScore.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
}
