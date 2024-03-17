using UnityEngine;
using UnityEngine.UI;

public class ButtonClickSound : MonoBehaviour
{
    public AudioClip clickSound; // Sound effect to play
    private AudioSource audioSource; // Reference to AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to any GameObject in the scene
        audioSource = FindObjectOfType<AudioSource>();

        // Ensure the AudioSource exists
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found in the scene. Please attach an AudioSource to any GameObject.");
            return;
        }

        // Get the Button component attached to this GameObject and register a listener for the click event
        Button button = GetComponent<Button>();
        button.onClick.AddListener(PlayClickSound);
    }

    // Function to play the click sound when the button is clicked
    void PlayClickSound()
    {
        // Check if a sound effect is assigned
        if (clickSound != null)
        {
            // Play the assigned sound effect through the AudioSource component
            audioSource.PlayOneShot(clickSound);
        }
        else
        {
            Debug.LogWarning("No click sound assigned to the button.");
        }
    }
}
