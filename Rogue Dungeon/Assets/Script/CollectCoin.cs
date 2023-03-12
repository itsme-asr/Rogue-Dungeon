using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] GameObject pointsCollectionEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            GameObject effect = Instantiate(pointsCollectionEffect, transform.position, Quaternion.identity);
            Destroy(effect, .75f);
            Destroy(other.gameObject);
            //Debug.Log("Collision");
            //            GameObject.FindWithTag("Coin").transform.GetComponent<Score>().ScorePoints += 1;
            GameObject.Find("Score").GetComponent<Score>().ScorePoints += 1;
        }
    }
}
