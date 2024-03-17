using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        // Invoke the LoadSceneDelayed method with a delay of 1 second
        Invoke("LoadStartDelayed", 0.2f);
    }

    private void LoadStartDelayed()
    {
        // Load the game scene after 1 second delay
        SceneManager.LoadScene("GoldCopy/StoryCutscene");
    }
    public void Credits()
    {
        Invoke("LoadCreditsDelayed", 0.2f);
        // Load the game scene when the "Start" button is clicked
     
    }
    private void LoadCreditsDelayed()
    {
        // Load the game scene after 1 second delay
        SceneManager.LoadScene("GoldCopy/Credits");
    }
    public void AboutGame()
    {
        Invoke("LoadAboutDelayed", 0.2f);
       
    }
    private void LoadAboutDelayed()
    {
        // Load the game scene after 1 second delay
        SceneManager.LoadScene("GoldCopy/AboutGame");
    }
    public void QuitGame()
    {
        Invoke("LoadQuitDelayed", 0.2f);
       
    }
    private void LoadQuitDelayed()
    {
        // Load the game scene after 1 second delay
        Application.Quit();
    }
    public void BackToMenu()
    {
        Invoke("LoadBackDelayed", 0.2f);
        // Quit the application when the "Quit" button is clicked
    
    }
    private void LoadBackDelayed()
    {
        // Load the game scene after 1 second delay
        SceneManager.LoadScene("GoldCopy/MainMenu");
    }

}