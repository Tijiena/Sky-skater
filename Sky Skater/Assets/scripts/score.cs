using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour

{
    public Text scoreText;
    public Text highscore;
    public float scoreAmount;
    public float time;
    public float pointIncreasedPerSecond;
    public static float totalscore;

    public Text countText;
    private int count;

    void Start()
    {

        pointIncreasedPerSecond = 1f;


    }
    // Start is called before the first frame update
    void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("balloon2");
        count = objectsWithTag.Length;
        countText.text = "Balloon: " + count;

        time += pointIncreasedPerSecond * Time.deltaTime;

        scoreText.text = "Score: " + scoreAmount;
        scoreAmount = 10000-(50 * (int)time)-count*100;
        totalscore = scoreAmount;
    }
}
