using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public GameObject tickBox;
    public GameObject nextItem;

    public ParticleSystem success;
    public AudioSource collect;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            success.Play();
            collect.Play();
            tickBox.SetActive(true);
            nextItem.SetActive(true);
        }
    }
}
