using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text bestScore;
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
            PlayerPrefs.SetInt("best", scorePoints);

        }
    }

    private void Start()
    {
        ScorePoints = 0;

    }

}
