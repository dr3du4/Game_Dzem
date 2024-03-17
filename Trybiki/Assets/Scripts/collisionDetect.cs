using System;
using UnityEngine;

public class SpriteCollision : MonoBehaviour
{

    public Rybik_Stats rybolStats;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Kubot") || other.CompareTag("Spare"))
        {
            rybolStats.hp -= 10;
            Debug.Log("poke");
        }
    }
}