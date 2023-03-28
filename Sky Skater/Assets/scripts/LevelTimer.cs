using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public Text scoreText;
    public Text highscore;
    public float scoreAmount;
    public float pointIncreasedPerSecond;

     void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;

        //void SetHighscore()
        //{
          //  PlayerPrefs.SetInt("Highscore", (int)scoreAmount);
            //highscore.text = PlayerPrefs.GetInt("Highscore").ToString();

           // if (PlayerPrefs.GetInt("Highscore") < scoreAmount)
            //{
              //  SetHighscore();
            //}


        //}

    }

     void Update()
    {

        scoreText.text =  "Time: " + (int)scoreAmount;
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;

    }

}

