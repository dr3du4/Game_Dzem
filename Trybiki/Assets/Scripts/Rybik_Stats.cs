using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Rybik_Stats : MonoBehaviour
{
   
    public int hp=100;
    public Slider hpSlider;
    public GameObject puf;
    public int damge;



    void Start()
    {
        
        hpSlider.value = hp;
      
    }

   
    private void Update()
    {
        hpSlider.value = hp;
        if (hp <= 0)
        {
            Instantiate(puf, transform.position, transform.rotation);
            
            Destroy(this.GameObject());
        }
    }
}
