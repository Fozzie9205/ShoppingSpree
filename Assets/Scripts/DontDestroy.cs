using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy Instance;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
