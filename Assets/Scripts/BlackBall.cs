using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBall : Ball
{ 
    public void OnMouseDown()
    {
        gameManager.Score += points;
        Explode("BasicSpark 2");
    }
}
