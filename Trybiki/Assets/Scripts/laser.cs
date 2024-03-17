using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
 public string playerTag = "Player"; // Tag gracza
    public float speed = 5f; // Prędkość pocisku
    public float maxDistance = 50f; // Maksymalna odległość, po której pocisk zostanie zniszczony
   
    private Transform player; // Referencja do obiektu gracza
    private Vector3 initialPosition; // Początkowa pozycja pocisku

    void Start()
    {
        // Znajdujemy obiekt gracza na scenie
        player = GameObject.FindGameObjectWithTag(playerTag).transform;

        // Ustalamy początkową pozycję pocisku
        initialPosition = transform.position;

        // Ustalamy kierunek ruchu pocisku w stronę gracza
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.up = direction; // Ustawiamy kierunek pocisku w stronę gracza
        }
    }

    void Update()
    {
        // Obracamy pocisk w kierunku gracza
       

        // Poruszamy pocisk w przód z zadaną prędkością
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Sprawdzamy, czy pocisk przekroczył maksymalną odległość
        if (Vector3.Distance(initialPosition, transform.position) >= maxDistance)
        {
            Destroy(gameObject); // Jeśli tak, niszczymy pocisk
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Jeśli pocisk koliduje z graczem, niszczymy pocisk
        if (other.CompareTag(playerTag))
        {
            Destroy(gameObject);
        }
    }

 
}