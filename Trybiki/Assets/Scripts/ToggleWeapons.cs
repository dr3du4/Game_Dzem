using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWeapons : MonoBehaviour
{
    
    public GameObject[] objectsToToggle;
    public bool spear;
    public bool shield;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ToggleObject(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (shield)
            {
                ToggleObject(1);
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (spear)
            {
                ToggleObject(2);
            }
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
