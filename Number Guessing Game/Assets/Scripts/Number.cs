using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    int guess;
    int minValue = 1;
    int maxValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to our Number Guessing Game.");
        Debug.Log("The number range is from " + minValue + " to " + maxValue );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
