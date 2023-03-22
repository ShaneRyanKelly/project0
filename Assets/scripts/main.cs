using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    bool running = true;
    string playerName = "Ralph";
    int score = 0;
    public int PlayerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the Game!");
        PlayTheGame();
        HealthStatus();
        DisplayParty();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    public void DisplayParty()
    {
        List<string> QuestPartyMembers = new List<string>() { "Grim", "Merlin", "Sterling" };
        int listLength = QuestPartyMembers.Count;
        for (int i = 0; i < QuestPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
            if (QuestPartyMembers[i] == "Merlin")
                Debug.Log("Hello Merlin!");
        }
    }

    public void HealthStatus(){
        while (PlayerLives > 0)
        {
            Debug.Log("Still alive!");
            PlayerLives--;
        }
        Debug.Log("Player KO'd...");
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
