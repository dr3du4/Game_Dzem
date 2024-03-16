using UnityEngine;

public class Spear : MonoBehaviour
{
    public float spearSpeed = 5f;
    public GameObject player; // Gracz
    private bool spearThrown = false;
    private Vector3 targetPosition;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    void Start()
    {
        originalRotation = transform.localRotation;
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        // Sprawdzamy, czy lewy przycisk myszy został naciśnięty
        if (Input.GetMouseButtonDown(0) && !spearThrown)
        {    originalPosition = transform.localPosition;
            
            
            
            // Ustalamy docelową pozycję na pozycję kursora myszy
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f;
            float distanceToPlayer = Vector3.Distance(player.transform.position, targetPosition);
            if (distanceToPlayer > 2f)
            {
                Vector3 directionToPlayer = (player.transform.position - targetPosition).normalized;
                targetPosition = player.transform.position - directionToPlayer * 2f;
            }
           
            
            RotateTowards(targetPosition);
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
                transform.localPosition = originalPosition;
                transform.localRotation = originalRotation; 
            }
        }
    }
    void RotateTowards(Vector3 targetPosition)
    {
        Vector3 direction = (targetPosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}