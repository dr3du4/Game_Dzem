using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject objectToSpawn; // Obiekt, który chcemy tworzyć
    public string playerTag = "Player"; // Tag gracza
    public float spawnDistance = 20f; // Maksymalna odległość gracza od spawnera
    public float spawnInterval = 3f; // Interwał czasowy między pojawieniem się obiektów

    private float timer = 0f;

    void Update()
    {
        // Zliczanie czasu
        timer += Time.deltaTime;

        // Sprawdzanie czy minął interwał czasowy
        if (timer >= spawnInterval)
        {
            // Sprawdzamy czy gracz jest w zasięgu
            GameObject player = GameObject.FindGameObjectWithTag(playerTag);
            if (player != null && Vector3.Distance(player.transform.position, transform.position) <= spawnDistance)
            {
                // Tworzymy nowy obiekt w miejscu rodzica
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            }

            // Resetujemy timer
            timer = 0f;
        }
    }
}
