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
    private void Start()
    {
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
