using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra : MonoBehaviour
{
    int a, b, c, answer;
    // Start is called before the first frame update
    void Start()
    {
        a = 1;
        b = 2;
        c = 3;

        Debug.Log("Today we are going to do some math!");
        
        answer = a + 1;

        Debug.Log(answer);

        Debug.Log("Some math: " + 1 + 2 + 3);
        Debug.Log("Variable Math: " + a + b + c);

        string firstName;
        string lastName;
        string fullName;

        firstName = "Shane";
        lastName = "Kelly";
        fullName = firstName + lastName;
        Debug.Log("My Full Name: " + fullName);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
