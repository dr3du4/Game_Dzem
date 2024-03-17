using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gate : MonoBehaviour
{
    public string targetTag = "Player"; // Tag obiektu gracza
    public string sceneToLoad; // Nazwa sceny do załadowania

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
