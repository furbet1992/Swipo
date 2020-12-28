using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "baseball", "flight", "boot", "presense", "eat", "insurance", "solution", "insurance", "length", "membership", "presentation", "guidance", "revolution" }; 

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord; 
    }
}
