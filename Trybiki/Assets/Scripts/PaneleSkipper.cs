using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaneleSkipper : MonoBehaviour
{

    public Sprite[] sprites; // Tablica sprite'ów
    private int currentIndex = 0; // Indeks bieżącego obrazu
    public GameObject button;
    void Start()
    {
        // Freezujemy grę na starcie
        Time.timeScale = 0f;
    }

    public void SwitchToNextImage()
    {
        // Sprawdzamy, czy istnieje następny obraz na liście
        if (currentIndex < sprites.Length - 1)
        {
            currentIndex++;

            // Wczytujemy i ustawiamy sprite następnego obrazu
            GetComponent<Image>().sprite = sprites[currentIndex];
        }
        else
        {
            // Jeśli to ostatni obraz, zamykamy ten obiekt i odfreezujemy grę
            gameObject.SetActive(false);
            Time.timeScale = 1f; // Odfreezowanie gry
            button.SetActive(false);
        }
    }
}
