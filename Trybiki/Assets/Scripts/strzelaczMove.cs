using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float moveSpeed = 5f; // Movement speed

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        // Check if player reference is set
        if (player == null)
        {
            Debug.LogWarning("Player reference not set!");
            return;
        }

        // Calculate distance between sprite and player
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Check if the distance is greater than 40 units
        if (distanceToPlayer > 4f)
        {
            // Move towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            // Move away from the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, -moveSpeed * Time.deltaTime);
        }
    }
}
