using UnityEngine;

public class CharacterMovementAudio : MonoBehaviour
{
    public AudioClip movingSound; // Sound to play when the character is moving
    private AudioSource audioSource; // Reference to the AudioSource component
    public float moveThreshold = 0.1f; // Minimum velocity magnitude to consider the character as moving

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check if the character's velocity magnitude is greater than the moveThreshold
        if (GetComponent<Rigidbody2D>().velocity.magnitude > moveThreshold)
        {
            // If the character is moving, and the audio is not already playing, play the moving sound
            if (!audioSource.isPlaying)
            {
                audioSource.clip = movingSound;
                audioSource.Play();
            }
        }
        else
        {
            // If the character is not moving, stop the audio
            audioSource.Stop();
        }
    }
}
