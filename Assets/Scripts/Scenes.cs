using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    //public string sceneName;
    private int completedLevel;

    private void Start()
    {
        //sceneName = "Level " + gameObject.name;
        if(SceneManager.GetActiveScene().name == "LevelSelect")
        {
            int i = 0;
            foreach (Transform t in transform)
            {
                if (i <= PlayerPrefs.GetFloat("CompletedLevel", 0f))
                {
                    try
                    {
                        t.GetComponent<Button>().interactable = true;
                    }
                    catch
                    {

                    }   
                }    
                i++;
            }
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect"); 
    }

    public void Level(string levelName)
    { 
        SceneManager.LoadScene(levelName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
