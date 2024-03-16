using UnityEngine;

public class Spear : MonoBehaviour
{
    public float spearSpeed = 5f;
    public GameObject player; // Gracz
    private bool spearThrown = false;
    private Vector3 targetPosition;
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        // Sprawdzamy, czy lewy przycisk myszy został naciśnięty
        if (Input.GetMouseButtonDown(0) && !spearThrown)
        {
            // Ustalamy docelową pozycję na pozycję kursora myszy
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f;

            // Ustawiamy flagę wyrzucania włóczni
            spearThrown = true;
        }

        // Jeśli włócznia została wyrzucona, przesuwamy ją w kierunku docelowej pozycji
        if (spearThrown)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, spearSpeed * Time.deltaTime);

            // Sprawdzamy, czy włócznia dotarła do docelowej pozycji
            if (transform.position == targetPosition)
            {
                // Resetujemy flagę i przesuwamy włócznię z powrotem do gracza
                spearThrown = false;
                transform.position = originalPosition;
            }
        }
    }
}