using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laucher : MonoBehaviour
{
    private float launchSpeed = 5f;
    [SerializeField] GameObject firePrefab;
    [SerializeField] Transform[] spawnPoints;

    private float mini = .1f;
    private float max = 3f;

    private void Start()
    {
        StartCoroutine(spawnFire());
    }

    IEnumerator spawnFire()
    {
        while (true)
        {
            float delay = Random.Range(mini, max);
            yield return new WaitForSeconds(delay);

            int randomPoint = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[randomPoint];

            GameObject cloneFire = Instantiate(firePrefab, spawnPoint.position, spawnPoint.rotation);

            Rigidbody2D rb = cloneFire.GetComponent<Rigidbody2D>();
            rb.AddForce(spawnPoint.up * launchSpeed, ForceMode2D.Impulse);

            Destroy(cloneFire, 2f);
        }
    }
}
