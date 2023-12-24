using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int scrollCount;
    public GameObject scrollCountDisplay;
    public GameObject scrollEndDisplay;

    // Update is called once per frame
    void Update()
    {
        scrollCountDisplay.GetComponent<Text>().text = "" + scrollCount;
        scrollEndDisplay.GetComponent<Text>().text = "" + scrollCount;

    }
}
