using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Walking : MonoBehaviour
{
   private Vector2 direction;
   public float speed = 5f;
   public float dashDistance = 3f;


   public GameObject objectB; // Obiekt, który ma być przesuwany

   private Vector3 originalPosition;

   private void Update()
   {
       
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");

       
       Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;
       transform.Translate(moveDirection * speed * Time.deltaTime);
       
       if (Input.GetKeyDown(KeyCode.Space))
       {
           // Przesuń postać o zadaną odległość w kierunku ruchu
           transform.Translate(moveDirection * dashDistance);
       }
       
       if (Input.GetMouseButtonDown(1))
       {
           originalPosition = objectB.transform.position;
           // Przesuń obiekt B o 2 jednostki w kierunku, w którym porusza się obiekt A
           objectB.transform.position += moveDirection * 2f;
          
           // Uruchom funkcję opóźniającą, aby obiekt B wrócił na swoje miejsce
           objectB.transform.position = originalPosition;
       }
       void ResetObjectBPosition()
       {
           objectB.transform.position = originalPosition;
       }
   }
   
    
}
