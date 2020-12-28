using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public wordManger WordManager;

    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            WordManager.TypeLetter(letter); 
        }
    }
}
