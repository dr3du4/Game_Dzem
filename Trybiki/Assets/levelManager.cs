using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public List<GameObject> enemies;
    public GameObject entry;
    public GameObject tekst;
    public int enemyNUmber;
    private bool isKilled=false;
   

  

    void FindAllRybiks()
    {
        // Znajdujemy wszystkie obiekty z tagiem "Rybik" w scenie
        GameObject[] rybikArray = GameObject.FindGameObjectsWithTag("rybik");

        // Dodajemy każdy znaleziony obiekt do listy
        foreach (GameObject rybik in rybikArray)
        {
            enemies.Add(rybik);
        }
    }
    private void Start()
    {FindAllRybiks();
    
        enemyNUmber = enemies.Count;
    }

    private void Update()
    {
        if (enemyNUmber/2 >= enemies.Count)
        {
            entry.SetActive(true);
            tekst.SetActive(true);
        }

        if (enemies.Count == 0 && !isKilled)
        {
            Decision.instance.globalValue += 1;
            isKilled = true;
        }
    }
}
