using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] Transform[] spawnPoints;
    float miniDelay = .8f;
    float maxDelay = 5f;

    private void Start()
    {
        StartCoroutine(spawnRandomCoins());
    }

    IEnumerator spawnRandomCoins()
    {
        while (true)
        {
            int randomPoint = Random.Range(0, spawnPoints.Length);
            float Delay = Random.Range(miniDelay, maxDelay);
            yield return new WaitForSeconds(Delay);

            Transform spawnPoint = spawnPoints[randomPoint];

            GameObject cloneCoin = Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity);

            Destroy(cloneCoin, 1.2f);
        }
    }
}
