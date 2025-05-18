using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float endScore;

    public string sceneName;
    private int levelIndex = 0;

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

    private void Update()
    {
        // Keep in update or the score will be saved overall and not separately for each scene
        sceneName = SceneManager.GetActiveScene().name;
        levelIndex = SceneManager.GetActiveScene().buildIndex - 1; // This must be -1 so that the Menu can be first in the build index
    }
    public void Complete()
    {
        endScore = StopWatch.Instance.currentTime; //Set "endScore" as the time on the stopwatch, referencing the script.
        CheckHighScore();
        CompletedLevel();
    }

    void CompletedLevel()
    {
        if (levelIndex == PlayerPrefs.GetFloat("CompletedLevel", 0f))
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
        StopWatch.Instance.highScore.text = time.ToString(@"mm\:ss\:fff"); //Display "time" as a string in a time format using minutes,seconds,milliseconds
    }
}