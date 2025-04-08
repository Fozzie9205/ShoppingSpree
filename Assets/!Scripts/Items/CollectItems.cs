using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public GameObject winScreen;

    private static GameObject parentObject;
    private static List<GameObject> foodItems;
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

    private void Update()
    {
        if (foodItems.Count <= 0)
        {
            winScreen.SetActive(true);
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
            GameManager.Instance.Complete();
            StopWatch.Instance.StopStopwatch();
        }
    }
}
