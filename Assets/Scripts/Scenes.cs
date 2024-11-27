using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    private int completedLevel;
    
    private void Start()
    {
        Audios.IceFlowPlay();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Audios.IceFlowPlay();
        Time.timeScale = 1f;
    }

    public void Settings()
    {
        Audios.IceFlowPlay();
        SceneManager.LoadScene("Settings");
    }

    public void Credits()
    {
        Audios.IceFlowPlay();
        SceneManager.LoadScene("Credits");
    }

    public void LevelSelect()
    {
        Audios.IceFlowPlay();
        SceneManager.LoadScene("SelectScreen"); 
    }

    public void Level(string levelName)
    {
        Audios.CareFreePlay();
        Audios.Instance.iceFlow.Stop();
        SceneManager.LoadScene(levelName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
