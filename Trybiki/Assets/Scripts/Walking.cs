using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Walking : MonoBehaviour
{
   private Vector2 direction;
   public float speed = 5f;
   public float dashDistance = 3f;
    private bool isFacingRight = true;
    public PlayerStats stats;
    public GameObject objectB; // Obiekt, który ma być przesuwany

   private Vector3 originalPosition;

   private void Update()
   {
       
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");

       
       Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;
       transform.Translate(moveDirection * speed * Time.deltaTime);
        if (horizontalInput > 0 && isFacingRight)
        {
            FlipSprite();
        }
        else if (horizontalInput < 0 && !isFacingRight)
        {
            FlipSprite();
        }
        if(Input.GetKeyDown(KeyCode.Space))        {
            Debug.Log(stats.dashPower);
        }
        if (Input.GetKeyDown(KeyCode.Space) && stats.dashPower>=30)
        {
            stats.dashPower -= 30;
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

   }

    void FlipSprite()
    {
        // Toggle the facing direction
        isFacingRight = !isFacingRight;

        // Flip the sprite by reversing its scale along the x-axis
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}

