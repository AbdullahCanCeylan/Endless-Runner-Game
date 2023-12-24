using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScroll : MonoBehaviour
{
    public AudioSource scrollFX;

    void OnTriggerEnter(Collider other)
    {
        scrollFX.Play();
        CollectableControl.scrollCount +=1;
        this.gameObject.SetActive(false);
    }
}
