using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    public static Audios Instance;

    public AudioSource click;
    public AudioSource trolley;
    public AudioSource hooray;
    public AudioSource collect;
    public AudioSource iceFlow;
    public AudioSource careFree;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static void ClickPlay()
    {
        Instance.click.Play();
    }

    public static void TrolleyPlay()
    {
        Instance.trolley.Play();
    }

    public static void TrolleyStop()
    {
        Instance.trolley.Stop();
    }

    public static void HoorayPlay()
    {
        Instance.hooray.Play();
    }

    public static void CollectPlay()
    {
        Instance.collect.Play();
    }

    public static void IceFlowPlay()
    {
        if (Instance.iceFlow != null && !Instance.iceFlow.isPlaying)
        {
            Instance.iceFlow.Play();
        }
    }

    public static void CareFreePlay()
    {
        if (Instance.careFree != null && !Instance.careFree.isPlaying)
        {
            Instance.careFree.Play();
        }
    }
}
