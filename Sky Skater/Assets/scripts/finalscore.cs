using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalscore : MonoBehaviour
{
    public score script;
    public Text lastscore;
    

    public void Start()
    {
        lastscore.text="Score: "+score.totalscore;
    }

}
