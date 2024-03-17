using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossManager : MonoBehaviour
{
   public GameObject boss;
   private Rybik_Stats stats;
   
   public int score;
   
   private void Start()
   {
      stats = boss.GetComponent<Rybik_Stats>();
      score = Decision.instance.globalValue;
   }
   
   private void Update()
   {
     
      if (stats.hp<=0)
      {
         if (score >= 2)
         {
            SceneManager.LoadScene("GoldCopy/win2");

            
            
         }
         else
         {
            SceneManager.LoadScene("GoldCopy/win1");

         }
      }
   }
}
