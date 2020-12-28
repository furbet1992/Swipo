using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //how much each live is worth --> the player script holds the Final life. 
    public Player playerHealth; 


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "word")
        {
            playerHealth.currentLives++;
            Destroy(this.gameObject); 
            Destroy(collision.gameObject); 
        }

    }
}
