using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    public AudioSource click;
    public AudioSource trolley;
    public AudioSource hooray;
    public AudioSource collect;
    public AudioSource iceFlow;
    public AudioSource careFree;

    public void ClickPlay()
    {
        click.Play();
    }

    public void TrolleyPlay()
    {
        trolley.Play();
    }

    public void TrolleyStop()
    {
        trolley.Stop();
    }

    public void HoorayPlay()
    {
        hooray.Play();
    }

    public void CollectPlay()
    {
        collect.Play();
    }

    public void IceFlowPlay()
    {
        iceFlow.Play();
    }

    public void CareFreePlay()
    {
        careFree.Play();
    }
}
