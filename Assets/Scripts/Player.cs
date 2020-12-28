using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int totalLives =5;
    public int currentLives;

    public HealthBar health;

    public bool gameOver;

    public GameObject deathUI; 

    private void Start()
    {
        currentLives = 0;
        gameOver = false; 
    }

    private void Update()
    {

        //when healthBar is triggered by the word, then totalLives will --; 
        if(currentLives == 5)
        {
            gameOver = true;
            
            StartCoroutine(GameOver());
        }



    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(1);
        deathUI.SetActive(true);
      
        if(gameOver == true)
        {
            Time.timeScale = 0;
        }
    }


}

