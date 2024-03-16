using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public Transform centerPoint; // Punkt centralny okręgu
    public float radius = 5f; // Promień okręgu
    public float rotationSpeed = 5f; // Prędkość obrotu

    void Update()
    {
        // Pobierz pozycję kursora myszki w przestrzeni świata gry
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Upewnij się, że pozycja Z kursora jest równa 0 (w płaszczyźnie gry)

        // Oblicz kierunek od środka okręgu do pozycji myszki
        Vector3 direction = (mousePosition - centerPoint.position).normalized;

        // Oblicz nową pozycję punktu zaczepienia (pivot) obiektu
        Vector3 pivotPosition = centerPoint.position + direction * radius;

        // Przesuń punkt zaczepienia do nowej pozycji
        transform.position = pivotPosition;

        // Oblicz kąt obrotu w stopniach na podstawie kierunku
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Obróć obiekt wokół punktu zaczepienia
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
