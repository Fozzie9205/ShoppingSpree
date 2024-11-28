using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public static Scenes Instance;

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
    private void Start()
    {
        Audios.IceFlowPlay();
    }

    public void MainMenu()
    {
        Audios.Instance.careFree.Stop();
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
        SceneManager.LoadScene("LevelSelect"); 
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
