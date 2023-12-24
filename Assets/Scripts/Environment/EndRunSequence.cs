using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndRunSequence : MonoBehaviour
{
    public GameObject liveScrolls;
    public GameObject liveDis;
    public GameObject endScreen;


    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(2);
        liveScrolls.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        

    }
}
