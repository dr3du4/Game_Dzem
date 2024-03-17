using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        // Start the coroutine to load the new scene after 15 seconds
        StartCoroutine(LoadSceneAfterDelay());
    }

    IEnumerator LoadSceneAfterDelay()
    {
        // Wait for 15 seconds
        yield return new WaitForSeconds(11f);

        // Load the new scene
        SceneManager.LoadScene("firstFloor");
    }
}
