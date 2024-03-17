using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float dashPower=25;
    public int hp=100;
    public Slider dashSlider1; 
    public Slider hpSlider2;





    void Start()
    {
        InvokeRepeating("Increment", 0f, 0.2f);
        dashSlider1.value = dashPower;
        hpSlider2.value = hp;
    }

    void Increment()
    {
        dashPower += 1f; 
    }

    private void Update()
    {
        dashSlider1.value = dashPower;
        hpSlider2.value = hp;
    }
}
