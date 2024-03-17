using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{
    public Vector3 destination; // Destination position
    public float speed = 5f; // Movement speed

    private bool isMoving = false; // Flag to indicate if the object is currently moving

    void Update()
    {
        // Check if the object is not currently moving and there's a new destination set
        if (!isMoving && destination != transform.position)
        {
            // Start moving towards the destination
            isMoving = true;
            StartCoroutine(MoveToDestination());
        }
    }

    IEnumerator MoveToDestination()
    {
        // Calculate the distance to the destination
        float distance = Vector3.Distance(transform.position, destination);

        // While the object hasn't reached the destination
        while (distance > 0.01f)
        {
            // Calculate the step size based on speed and frame rate
            float step = speed * Time.deltaTime;

            // Move the object towards the destination
            transform.position = Vector3.MoveTowards(transform.position, destination, step);

            // Recalculate the distance to the destination
            distance = Vector3.Distance(transform.position, destination);

            yield return null; // Wait for the next frame
        }

        // Ensure the object reaches exactly the destination position
        transform.position = destination;

        // Reset the flag for next movement
        isMoving = false;
    }
}
