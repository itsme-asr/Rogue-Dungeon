using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int scorePoints;
    public int ScorePoints
    {
        get
        {
            return scorePoints;
        }

        set
        {
            scorePoints = value;
            // Debug.Log(scorePoints);
            GetComponent<Text>().text = "Score: " + scorePoints;
        }
    }

    private void Start()
    {
        ScorePoints = 0;
    }

    private void Update()
    {
        //Debug.Log(scorePoints);
    }
}
