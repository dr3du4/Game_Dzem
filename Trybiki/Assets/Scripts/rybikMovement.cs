using UnityEngine;

public class RybikMovement : MonoBehaviour
{
    public Transform player; // Reference to the player's sprite
    public float speed = 1f; // Speed of movement

    void Update()
    {
        if (player != null)
        {
            // Calculate direction towards the player's position
            Vector3 direction = (player.position - transform.position).normalized;

            // Move towards the player's position with interpolation for smooth movement
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}