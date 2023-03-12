using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathEffect;
    [SerializeField] public bool death = false;
    Best best;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            death = true;
            GameObject deathParticleEffect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(other.gameObject, .1f);
            Destroy(deathParticleEffect, 1f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Update()
    {
        if (death == true)
        {
            //best.bestScore();
        }
    }
}
