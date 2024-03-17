using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rybik_Stats : MonoBehaviour
{
   
    public int hp=100;
    public Slider hpSlider;

    public int damge;



    void Start()
    {
        
        hpSlider.value = hp;
      
    }

   
    private void Update()
    {
        hpSlider.value = hp;
    }
}
