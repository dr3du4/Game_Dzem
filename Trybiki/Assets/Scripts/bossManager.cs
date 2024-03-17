using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class bossManager : MonoBehaviour
{
   public GameObject boss;
   public GameObject evilEnding;
   public GameObject goodEnding;
   public int score;
   public GameObject player;
   private void Start()
   {

      score = Decision.instance.globalValue;
   }

   private void Update()
   {

      if (!boss)
      {
         if (score >= 2)
         {
            evilEnding.SetActive(true);
            Time.timeScale = 0f;
            
         }
         else
         {
            goodEnding.SetActive(true);
            Time.timeScale = 0f;
         }
      }
   }
}
