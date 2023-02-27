using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    bool running = true;
    string playerName = "Ralph";
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the Game!");
        PlayTheGame();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void PlayTheGame()
    {
        // always executes
        if (running)
            Debug.Log("Hello, " + playerName);
        // never executes
        else if (running == false)
            Debug.Log("Game is Not Running.");

        // never executes
        if (!running)
            Debug.Log("Game is Not Running.");
        // always executes
        else
            Debug.Log("Game is Running");

        // executes first time function called
        if (score == 0)
            score++;
        // executes if function called again
        else if (score > 0)
            score++;
        // never executes
        else
            score--;

        if (score >= 1 && running)
        {
            Debug.Log("Game Running");
            Debug.Log("Scored");
            Debug.Log("Ready");
            if (playerName == "Ralph")
            {
                Debug.Log("Thank you for playing, " + playerName);
            }
        }
    }

    void CheckInput()
    {

    }
}
