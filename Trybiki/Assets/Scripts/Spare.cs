using Unity.VisualScripting;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefabrykat pocisku
    public float speed = 20f; // Prędkość pocisku
    private Vector3 initialPosition; // Początkowa pozycja początkowa
    private GameObject projectile;
    void Start()
    {
        initialPosition = transform.position; // Zapisujemy początkową pozycję
    }

    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
           
            projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            
            Vector3 initialCursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            initialCursorPosition.z = 0f; 
            Vector3 direction = (initialCursorPosition - transform.position).normalized;

         
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        
        
    }
}