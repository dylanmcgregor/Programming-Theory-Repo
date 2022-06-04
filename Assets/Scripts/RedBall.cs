using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{

    public void OnMouseDown()
    {
        Explode("BasicSpark 3");
        gameManager.GameOver();
    }

    public override void Explode(string name)
    {
        GameObject explosionParticle = GameObject.Find(name);
        explosionParticle.transform.position = transform.position;
        explosionParticle.GetComponent<ParticleSystem>().Play();
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));

    }
}
