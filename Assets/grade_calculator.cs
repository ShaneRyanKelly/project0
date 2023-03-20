using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grade_calculator : MonoBehaviour
{
    string student = "Shane Kelly";
    int[] grades = new int[10] {100, 92, 87, 200, -20, 52, 82, 75, 67, 88};
    int total = 0;
    float average;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome " + student + "!");
        Debug.Log("Here are your grades: ");

        for (int i = 0; i < grades.Length; i++){
            total += grades[i];
            if (grades[i] <= 100 && grades[i] >= 90){
                Debug.Log("This grade is an A!");
                if (grades[i] == 100)
                    Debug.Log("WOW! A perfect score!");
            }
            else if (grades[i] <= 89 && grades[i] >= 80){
                Debug.Log("This grade is a B.");
            }
            else if (grades[i] <= 79 && grades[i] >= 70){
                Debug.Log("This grade is a C.");
            }
            else if (grades[i] <= 69 && grades[i] >= 65){
                Debug.Log("This grade is a D.");
            }
            else if (grades[i] <= 64 && grades[i] >= 0){
                Debug.Log("This grade is a F.");
            }
            else{
                Debug.Log("This is out of range, how did you even get this grade?");
            }
        }
        average = total / grades.Length;
        Debug.Log("Average: " + average);
        Debug.Log("All Grades displayed!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
