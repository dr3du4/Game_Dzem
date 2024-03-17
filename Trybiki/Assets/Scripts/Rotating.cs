using UnityEngine;
using System.Collections;

public class ImageRotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second

    void Start()
    {
        // Start the rotation coroutine when the script starts
        StartCoroutine(RotateImage());
    }

    IEnumerator RotateImage()
    {
        while (true)
        {
            // Rotate the image gradually
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

            // Wait for the next frame
            yield return null;
        }
    }
}
