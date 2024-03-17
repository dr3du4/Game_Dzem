using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{


    public PlayerStats stats;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("rybik"))
        {
            Rybik_Stats RybolStats =other.GetComponent<Rybik_Stats>();
            stats.hp -= RybolStats.damge;
            
                
        }
        if (other.CompareTag("Laser"))
        {
            stats.hp -= 5;
        }
    }
}
