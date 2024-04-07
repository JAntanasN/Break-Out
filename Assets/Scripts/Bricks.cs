using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int hits = 1;
    public int points = 100;


    void OnCollisionEnter2D(Collision2D other)
    {
        hits--;
        GameManager.score += points;
        if(hits <= 0)
        {
            Destroy(gameObject);
        }
    }
}
