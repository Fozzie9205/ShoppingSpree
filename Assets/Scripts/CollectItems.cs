using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public static GameManager gameManager;
    public static StopWatch stopWatch;

    private static GameObject parentObject;
    private static List<GameObject> foodItems;
    private int currentActiveIndex = 0;
    void Start()
    {
        parentObject = GameObject.FindWithTag("FoodParent");
        foodItems = new List<GameObject>();

        foreach (Transform child in parentObject.transform)
        {
            foodItems.Add(child.gameObject);
        }

        for (int i = 0; i < foodItems.Count; i++)
        {
            foodItems[i].SetActive(i == 0);
        }
    }

    public static void CollectItem(GameObject collectedItem)
    {
        if (foodItems.Contains(collectedItem))
        {
            int index = foodItems.IndexOf(collectedItem);
            foodItems.Remove(collectedItem);
            collectedItem.SetActive(false);

            if (index < foodItems.Count)
            {
                foodItems[index].SetActive(true);
            }
        }

        if (foodItems.Count <= 0)
        {
            gameManager.Complete();
            stopWatch.StopStopwatch();
        }
    }
    void Update()
    {
        
    }
}
