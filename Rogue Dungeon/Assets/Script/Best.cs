using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Best : MonoBehaviour
{
    Text txt;

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    private void Update()
    {
        txt.text = " " + PlayerPrefs.GetInt("best");
    }
}
