using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TextMeshProUGUI highScore;

    public StopWatch stopwatch;
    public float endScore;

    public string sceneName;
    private int levelIndex = 0;
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        levelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void Complete()
    {
        endScore = stopwatch.currentTime; //Set "endScore" as the time on the stopwatch, referencing the script.
        CheckHighScore();
        CompletedLevel();
    }

    void CompletedLevel()
    {
        if (levelIndex == PlayerPrefs.GetFloat("CompletedLevel", 0))
        {
            PlayerPrefs.SetFloat("CompletedLevel", levelIndex + 1);
        }
    }

    void CheckHighScore()
    {
        if (endScore <= PlayerPrefs.GetFloat("HighScore" + sceneName, endScore))  //If "endScore" is less than or equal to the highscore stored, set the value as the new highscore
        {
            PlayerPrefs.SetFloat("HighScore" + sceneName, endScore); //Set "endScore" as the highscore
        }
        UpdateHighScoreText();
    }

    void UpdateHighScoreText()
    {
        TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("HighScore" + sceneName));  //Set the value of the saved highscore to "time"
        highScore.text = time.ToString(@"mm\:ss\:fff"); //Display "time" as a string in a time format using minutes,seconds,milliseconds
    }
}