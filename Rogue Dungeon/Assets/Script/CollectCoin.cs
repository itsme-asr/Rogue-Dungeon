using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("Collision");
            //            GameObject.FindWithTag("Coin").transform.GetComponent<Score>().ScorePoints += 1;
            GameObject.Find("Score").GetComponent<Score>().ScorePoints += 1;
        }
    }
}
