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
            PlayerPrefs.SetInt("best", scorePoints);
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
        onCheckBest();
    }

    private void Update()
    {
        updateBestScore();
    }

    private void onCheckBest()
    {
        if (scorePoints > PlayerPrefs.GetInt("best", 0))
        {
            PlayerPrefs.SetInt("best", scorePoints);
            updateBestScore();

        }
    }

    private void updateBestScore()
    {
        bestScore.text = "Best: " + PlayerPrefs.GetInt("best");
    }
}
