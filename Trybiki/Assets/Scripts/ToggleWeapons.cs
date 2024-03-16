using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWeapons : MonoBehaviour
{
    
    public GameObject[] objectsToToggle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ToggleObject(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ToggleObject(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ToggleObject(2);
        }
    }

    void ToggleObject(int index)
    {
        for (int i = 0; i < objectsToToggle.Length; i++)
        {
            if (i == index)
            {
                objectsToToggle[i].SetActive(true);
            }
            else
            {
                objectsToToggle[i].SetActive(false);
            }
        }
    }
}
