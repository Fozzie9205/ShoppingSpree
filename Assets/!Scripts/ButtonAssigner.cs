using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAssigner : MonoBehaviour
{
    public Button mainMenuButton;
    public Button mainMenuButton2;
    public Button settingsButton;
    public Button creditsButton;
    public Button levelSelectButton;
    public Button quitButton;
    public Button resumeButton;

    public Transform levelButtonsParent;
    void Start()
    {
        if (Scenes.Instance != null)
        {
            if (mainMenuButton != null) 
                mainMenuButton.onClick.AddListener(() => Scenes.Instance.MainMenu());

            if (mainMenuButton2 != null)
                mainMenuButton2.onClick.AddListener(() => Scenes.Instance.MainMenu());

            if (settingsButton != null)
                settingsButton.onClick.AddListener(() => Scenes.Instance.Settings());

            if (creditsButton != null)
                creditsButton.onClick.AddListener(() => Scenes.Instance.Credits());

            if (levelSelectButton != null)
                levelSelectButton.onClick.AddListener(() => Scenes.Instance.LevelSelect());

            if (quitButton != null)
                quitButton.onClick.AddListener(() => Scenes.Instance.Quit());

            if (resumeButton != null)
                resumeButton.onClick.AddListener(() => PauseMenu.Instance.Resume());

            AssignLevelButtons();
        }
        else
        {
            Debug.LogError("Scenes instance not found!");
        }
    }

    void AssignLevelButtons()
    {
        if (levelButtonsParent != null)
        {
            int levelIndex = 1; // Start from Level 1

            foreach (Transform buttonTransform in levelButtonsParent)
            {
                Button levelButton = buttonTransform.GetComponent<Button>();

                if (levelButton != null)
                {
                    string levelName = "Level " + levelIndex; // Construct level name dynamically
                    levelButton.onClick.AddListener(() => Scenes.Instance.Level(levelName));
                    levelIndex++;
                }
            }
        }
    }
}
