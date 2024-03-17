using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Egg : MonoBehaviour
{
   public GameObject[] prefabsToSpawn; // Tablica obiektów prefab, które chcemy tworzyć
    public BoxCollider2D spawnArea; // Obszar, w którym mają pojawiać się obiekty

    private GameObject spawnedObject;
    private float spawnTimer = 0f;
    private float spawnInterval = 3f; // Czas (w sekundach) pomiędzy kolejnymi pojawieniami obiektów

    void Start()
    {
       
    }

    void Update()
    {
        // Liczenie czasu
        spawnTimer += Time.deltaTime;

        // Jeśli minął czas spawnu, generujemy obiekt i resetujemy timer
        if (spawnTimer >= spawnInterval)
        {
            SpawnPrefab();
            spawnTimer = 0f;
            Destroy(this.GameObject());
        }
    }

    // Metoda do generowania obiektu prefab w tej samej pozycji, co poprzedni obiekt
    void SpawnPrefab()
    {
        if (prefabsToSpawn.Length > 0 && spawnArea != null)
        {
            // Obliczamy pozycję na podstawie środka obszaru spawnu
            Vector2 spawnPosition = spawnArea.bounds.center;

            // Zniszcz poprzedni obiekt, jeśli istnieje
            if (spawnedObject != null)
            {
                Destroy(spawnedObject);
            }

            // Tworzymy obiekt prefab w wyznaczonej pozycji
            spawnedObject = Instantiate(prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)], spawnPosition, Quaternion.identity);
            
            // Zniszcz obiekt po 5 sekundach
            Destroy(spawnedObject, 5f);
        }
        else
        {
            Debug.LogWarning("PrefabsToSpawn lub SpawnArea nie są przypisane lub tablica prefabsToSpawn jest pusta!");
        }
    }
}

