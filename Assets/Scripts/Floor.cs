using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.name.Contains("Red"))
        {
            gameManager.GameOver();
        }
        Destroy(other.gameObject);
    }

}
