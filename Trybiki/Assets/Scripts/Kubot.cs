using UnityEngine;

public class Kubot : MonoBehaviour
{
    public Transform player; // Referencja do obiektu player
    public float radius = 1.0f; // Promień ruchu klapka
    public float speed = 200.0f; // Prędkość ruchu klapka

    private bool isMoving = false; // Flaga określająca, czy skrypt ma być aktywny
    private float angle = 145.0f; // Początkowy kąt

    void Update()
    {
        if (isMoving)
        {
            // Aktualizacja kąta na podstawie prędkości
            angle += speed * Time.deltaTime;

            // Jeśli kąt przekroczy 135 stopni, zatrzymaj skrypt
            if (angle > 225.0f)
            {
                angle = 145.0f;
                isMoving = false; // Zatrzymaj skrypt
            }

            // Oblicz pozycję klapka na podstawie aktualnego kąta
            Vector3 offset = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0) * radius;
            transform.position = player.position + offset;
        }

        // Sprawdź, czy klawisz "S" został naciśnięty
        if (Input.GetMouseButtonDown(0))
        {
            // Rozpocznij ruch klapka
            isMoving = true;
        }
    }
}