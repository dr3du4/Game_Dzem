using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonSound : MonoBehaviour
{
    public AudioClip soundEffect; // Sound effect to be played
    private AudioSource audioSource; // Reference to the AudioSource component
    public Button button; // Reference to the button component

    void Start()
    {
        // Get the AudioSource component from any GameObject in the scene
        audioSource = FindObjectOfType<AudioSource>();

        // Ensure the AudioSource exists
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found in the scene. Please attach an AudioSource to any GameObject.");
            return;
        }

        // Get the Button component attached to this GameObject
        if (button == null)
            button = GetComponent<Button>();

        // Register a listener to the button's onClick event
        button.onClick.AddListener(PlaySound);
    }

    // Function to play the sound when the button is clicked
    void PlaySound()
    {
        // Check if a sound effect is assigned
        if (soundEffect != null)
        {
            // Play the assigned sound effect through the AudioSource component
            audioSource.PlayOneShot(soundEffect);
        }
        else
        {
            Debug.LogWarning("No sound effect assigned to the button.");
        }
    }
}
