using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public PlayerStats stats;
    public ToggleWeapons weapons;


  

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ApapDzien")) // Sprawdź, czy zderzył się z graczem
        {
            if (Input.GetKeyDown(KeyCode.E)) // Sprawdź, czy naciśnięto klawisz E
            {

                stats.hp -= 25;
                Destroy(other.gameObject);
            }
            
        }
        
        else if (other.CompareTag("ApapNoc")) // Sprawdź, czy zderzył się z graczem
        {
            if (Input.GetKeyDown(KeyCode.E)) // Sprawdź, czy naciśnięto klawisz E
            {
                
                stats.hp += 25;
                Destroy(other.gameObject);
            }
            
        }
        
        else if (other.CompareTag("Amol")) // Sprawdź, czy zderzył się z graczem
        {
            if (Input.GetKeyDown(KeyCode.E)) // Sprawdź, czy naciśnięto klawisz E
            {
                
                stats.hp += 10;
                stats.dashPower += 30; 
                Destroy(other.gameObject);
            }
            
        }
        
        else if (other.CompareTag("Spare")) // Sprawdź, czy zderzył się z graczem
        {
            if (Input.GetKeyDown(KeyCode.E)) // Sprawdź, czy naciśnięto klawisz E
            {

                weapons.spear = true;
                
                Destroy(other.gameObject);
            }
            
        }
        else if (other.CompareTag("Shield")) // Sprawdź, czy zderzył się z graczem
        {
            if (Input.GetKeyDown(KeyCode.E)) // Sprawdź, czy naciśnięto klawisz E
            {

                weapons.shield = false;
                Destroy(other.gameObject);
            }
            
        }
        
    }
}
