using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour

{
    public string tagToCount;
    public Text countText;
    private int count;

    // Start is called before the first frame update
    void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToCount);
        count = objectsWithTag.Length;
        countText.text = "Number of objects with the \"" + tagToCount + "\" tag: " + count;

    }
}
