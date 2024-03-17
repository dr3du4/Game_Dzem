using UnityEngine;

public class SpriteCollision : MonoBehaviour
{
    // This function is called when another collider enters the trigger collider attached to this GameObject
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a GameObject tagged as "Player"
        if (collision.gameObject.CompareTag("rybik"))
        {
            Debug.Log("Collision with player detected!");
            // Add your collision handling code here
        }
    }
}