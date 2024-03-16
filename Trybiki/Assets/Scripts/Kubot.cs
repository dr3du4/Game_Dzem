using UnityEngine;
using System.Collections;

public class Kubot : MonoBehaviour
{
    public Transform pointA; // Obiekt A
    public float orbitSpeed = 100f; // Prędkość obrotu w stopniach na sekundę
    

    private float currentAngle=180; // Aktualny kąt obrotu
    private float distanceFromPointA; // Odległość między A i B
    private bool isMoving = false; // Flaga informująca, czy obiekt jest w ruchu

    private Vector3 initialPosition; // Początkowa pozycja obiektu

    void Start()
    {
        // Automatycznie ustaw odległość na podstawie promienia okręgu
        distanceFromPointA = Vector2.Distance(transform.position, pointA.position);

        // Zapisz początkową pozycję obiektu
        initialPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveObject());
        }
    }

    IEnumerator MoveObject()
    {
        float targetAngle = currentAngle + 45f; // 45 stopni w górę od aktualnego kąta

        while (currentAngle < targetAngle)
        {
            currentAngle += orbitSpeed * Time.deltaTime;
            float radianAngle = Mathf.Deg2Rad * currentAngle;
            Vector3 orbitPosition = new Vector3(
                pointA.position.x + distanceFromPointA * Mathf.Cos(radianAngle),
                pointA.position.y + distanceFromPointA * Mathf.Sin(radianAngle),
                transform.position.z
            );

            transform.position = orbitPosition;
            yield return null;
        }

        // Ustaw pozycję na początkową, aby uniknąć błędów zaokrągleń
        transform.position = initialPosition;
        currentAngle += -45;
        isMoving = false; // Zakończ ruch
    }
}