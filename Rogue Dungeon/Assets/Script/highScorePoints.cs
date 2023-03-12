using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScorePoints : MonoBehaviour
{
    [SerializeField] Text txt;
    private void Start()
    {
        txt.text = " " + PlayerPrefs.GetInt("best");
    }
}
