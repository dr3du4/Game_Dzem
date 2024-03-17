using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flyingSpare : MonoBehaviour
{
    private Vector3 startPosition; // Pozycja początkowa

    void Start()
    {
        startPosition = transform.position; // Zapisujemy pozycję początkową
    }

    void Update()
    {
        // Resetujemy rotację obiektu przy każdej klatce
        transform.rotation = Quaternion.identity;

        // Sprawdzamy odległość od punktu startowego
        if (Vector3.Distance(transform.position, startPosition) > 30f)
        {
            // Jeśli odległość przekracza 30 jednostek, niszczymy obiekt
            Destroy(gameObject);
        }
    }
   
}
