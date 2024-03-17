using UnityEngine;

public class Kubot : MonoBehaviour
{
    public float speed = 5.0f; // Prędkość ruchu klapki
    public float downDuration = 0.1f; // Czas trwania ruchu w dół
    public float upDuration = 0.1f; // Czas trwania ruchu w górę

    private bool isMoving = false; // Flaga określająca, czy skrypt ma być aktywny
    private bool isMovingDown = false; // Flaga określająca, czy klapka jest obecnie w ruchu w dół
    private float timer = 0.0f; // Licznik czasu dla ruchu w dół i w górę




void Update()
    {

        // Sprawdź, czy nastąpiło kliknięcie myszą
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            // Rozpocznij ruch klapki
            isMoving = true;
        }

        // Sprawdź, czy klapka jest obecnie w ruchu
        if (isMoving)
        {
            // Jeśli klapka jest obecnie w ruchu w dół
            if (isMovingDown)
            {
                // Zwiększaj timer dla ruchu w dół
                timer += Time.deltaTime;

                // Oblicz przemieszczenie w dół na podstawie prędkości
                Vector3 offset = Vector3.down * speed * Time.deltaTime;

                // Aktualizuj pozycję klapki
                transform.position += offset;

                // Sprawdź, czy minął czas ruchu w dół
                if (timer >= downDuration)
                {
                    // Zmień kierunek ruchu na w górę, zresetuj timer i flagę ruchu
                    isMovingDown = false;
                    timer = 0.0f;
                    isMoving = true;
                }
            }
            else // Jeśli klapka nie jest obecnie w ruchu w dół, to znaczy, że jest w ruchu w górę
            {
                // Zwiększaj timer dla ruchu w górę
                timer += Time.deltaTime;

                // Oblicz przemieszczenie w górę na podstawie prędkości
                Vector3 offset = Vector3.up * speed * Time.deltaTime;

                // Aktualizuj pozycję klapki
                transform.position += offset;

                // Sprawdź, czy minął czas ruchu w górę
                if (timer >= upDuration)
                {
                    // Zmień kierunek ruchu na w dół, zresetuj timer i flagę ruchu
                    isMovingDown = true;
                    timer = 0.0f;
                    isMoving = false;
                }
            }
        }

    }
}
