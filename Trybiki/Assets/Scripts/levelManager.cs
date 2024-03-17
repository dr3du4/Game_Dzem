using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    
    
       public List<GameObject> enemies;
    public GameObject entry;
    public GameObject tekst;
    public int enemyNumber;
    private bool isKilled = false;

    void FindAllRybiks()
    {
        // Znajdujemy wszystkie obiekty z tagiem "Rybik" w scenie
        GameObject[] rybikArray = GameObject.FindGameObjectsWithTag("rybik");

        // Dodajemy każdy znaleziony obiekt do listy
        foreach (GameObject rybik in rybikArray)
        {
            // Sprawdzamy, czy obiekt już istnieje na liście, aby uniknąć duplikatów
            if (!enemies.Contains(rybik))
            {
                enemies.Add(rybik);
            }
        }
    }

    void RemoveDestroyedEnemies()
    {
        // Tworzymy nową listę na obiekty, które mają zostać usunięte
        List<GameObject> toRemove = new List<GameObject>();

        // Iterujemy przez obiekty na liście
        foreach (GameObject enemy in enemies)
        {
            // Jeśli obiekt został zniszczony, dodajemy go do listy obiektów do usunięcia
            if (enemy == null)
            {
                toRemove.Add(enemy);
            }
        }

        // Usuwamy zniszczone obiekty z listy głównej
        foreach (GameObject enemyToRemove in toRemove)
        {
            enemies.Remove(enemyToRemove);
        }
    }

    private void Start()
    {
        FindAllRybiks();
        enemyNumber = enemies.Count;
    }

    private void Update()
    {
        FindAllRybiks();
        RemoveDestroyedEnemies();

        

        // Sprawdzamy, czy liczba wrogów zmniejszyła się do połowy początkowej liczby
        if (enemyNumber  >= 2*enemies.Count)
        {
           entry.SetActive(true);
            tekst.SetActive(true);
        }

        // Sprawdzamy, czy wszystkie wrogowie zostali zniszczeni
        if (enemies.Count == 0 && !isKilled)
        {
            // Zwiększamy globalną wartość decyzji
            Decision.instance.globalValue += 1;
            isKilled = true;
        }
    }
}
