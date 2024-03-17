using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puf : MonoBehaviour
{

    public float delay = 2f; // Opóźnienie przed zniszczeniem obiektu

    void Start()
    {
        // Wywołujemy metodę DestroyObject po zadanym opóźnieniu
        Invoke("DestroyObject", delay);
    }

    void DestroyObject()
    {
        // Niszczymy ten obiekt
        Destroy(gameObject);
    }
}

