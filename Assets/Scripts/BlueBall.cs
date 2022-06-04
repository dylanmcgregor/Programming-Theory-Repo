using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class BlueBall : Ball
{
    public void OnMouseDown()
    {
        gameManager.Score += points;
        Explode("BasicSpark");
    }
}
