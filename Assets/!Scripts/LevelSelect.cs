using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Transform targetParent;
    void Start()
    {
        //targetParent = transform.Find("Buttons");
        if (SceneManager.GetActiveScene().name == "LevelSelect")
        {
            int i = 0;
            foreach (Transform t in targetParent)
            {
                if (i <= PlayerPrefs.GetFloat("CompletedLevel", 0f))
                {
                    try
                    {
                        t.GetComponent<Button>().interactable = true;
                    }
                    catch
                    {
                        Debug.LogWarning($"No Button component found on {t.name}");
                    }
                }
                i++;
            }
        }
    }

    void Update()
    {
        
    }
}
