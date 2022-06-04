using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    protected GameManager gameManager;
    public int points;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public virtual void Explode(string name)
    {
        GameObject explosionParticle = GameObject.Find(name);
        explosionParticle.transform.position = transform.position;
        explosionParticle.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject);

    }
}
