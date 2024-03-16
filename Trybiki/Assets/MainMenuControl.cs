using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene when the "Start" button is clicked
        SceneManager.LoadScene("SampleScene");
    }
    public void Credits()
    {
        // Load the game scene when the "Start" button is clicked
        SceneManager.LoadScene("Credits");
    }
    public void AboutGame()
    {
        // Load the game scene when the "Start" button is clicked
        SceneManager.LoadScene("AboutGame");
    }
    public void QuitGame()
    {
        // Quit the application when the "Quit" button is clicked
        Application.Quit();
    }
    public void BackToMenu()
    {
        // Quit the application when the "Quit" button is clicked
        SceneManager.LoadScene("MainMenu");
    }
}