using UnityEngine;

public class FaceDirection : MonoBehaviour
{
    public Transform player; // Reference to the player's sprite

    void Update()
    {
        if (player != null)
        {
            // Calculate direction from this sprite to the player's sprite
            Vector3 direction = player.position - transform.position;

            // Determine if the player is to the left or right of this sprite
            bool isPlayerToRight = (direction.x >= 0);

            // Flip the sprite's scale based on the direction
            if (isPlayerToRight)
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            else
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
}
