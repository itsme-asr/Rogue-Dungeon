using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Best : MonoBehaviour
{
    Text txt;
    //[SerializeField] Enemy enemy;

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    private void Update()
    {
        //Debug.Log(GameObject.FindWithTag("Fire").GetComponent<Enemy>().death);
    }

    public void bestScore()
    {
        //if (GameObject.FindWithTag("Fire").GetComponent<Enemy>().death == false)
        //txt.text = "Best : " + PlayerPrefs.GetInt("best");

    }
}
