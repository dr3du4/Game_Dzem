using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision : MonoBehaviour
{
    public static Decision instance; // Singleton dla naszej zmiennej globalnej

    public int globalValue = 0; 

    void Awake()
    {
        // Sprawdzamy, czy istnieje już instancja tego obiektu
        if (instance == null)
        {
            // Jeśli nie, ustawiamy tę instancję jako obecną instancję
            instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszczymy tego obiektu przy zmianie sceny
        }
        else
        {
            // Jeśli instancja już istnieje, niszczymy tę instancję
            Destroy(gameObject);
        }
    }
}

