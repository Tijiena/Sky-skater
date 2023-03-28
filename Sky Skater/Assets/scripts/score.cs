using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour

{
    public Text countText;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("balloon");
        count = objectsWithTag.Length;
        countText.text = "balloon:" + count;

    }
}
