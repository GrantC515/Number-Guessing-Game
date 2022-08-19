
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    int guess = 50;
    int minValue = 1;
    int maxValue = 101;

    // Start is called before the first frame update
    void Start()
    {
       //code
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("is it higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed your number, play again?");
            Debug.Log("");
            StartGame();
        }
    }

    void StartGame()
    {
        guess = 50;
        minValue = 1;
        maxValue = 101;

        Debug.Log("Welcome to our Number Guessing Game.");
        Debug.Log("The number range is from " + minValue + " to 100");
        Debug.Log("Guess a number between the given range.");
        Debug.Log("Push Up arrow = Higher, Push Down arrow = Lower, Push Enter = Correct");
        Debug.Log("Tell me if your number is higher or lower than: " + guess + "?");
    }
}
