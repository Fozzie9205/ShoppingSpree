using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public GameObject tickBox;
    //public GameObject nextItem;

    public ParticleSystem success;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            CollectItems.CollectItem(this.gameObject);
            //Destroy(gameObject);
            success.Play();
            Audios.CollectPlay();
            tickBox.SetActive(true);
            //nextItem.SetActive(true);
        }
    }
}
