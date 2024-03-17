using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEggs : MonoBehaviour
{
    public GameObject prefabToSpawn; // Obiekt prefab, który chcemy tworzyć
    public BoxCollider2D spawnArea; // Obszar, w którym mają pojawiać się obiekty

    private float spawnTimer = 0f;
    public float spawnInterval = 3f; // Czas (w sekundach) pomiędzy kolejnymi pojawieniami obiektów

    void Update()
    {
        // Liczenie czasu
        spawnTimer += Time.deltaTime;

        // Jeśli minął czas spawnu, generujemy obiekt i resetujemy timer
        if (spawnTimer >= spawnInterval)
        {
            SpawnPrefab();
            spawnTimer = 0f;
        }
    }

    // Metoda do generowania obiektu prefab w losowej pozycji wewnątrz obszaru spawnu
    void SpawnPrefab()
    {
        if (prefabToSpawn != null && spawnArea != null)
        {
            // Obliczamy losową pozycję wewnątrz obszaru spawnu
            Vector2 spawnPosition = new Vector2(
                Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
                Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y)
            );

            // Tworzymy obiekt prefab na wyliczonej pozycji
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("PrefabToSpawn lub SpawnArea nie są przypisane!");
        }
    }
}
