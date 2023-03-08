using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = new int[5];
        string[] strings = new string[7];
        for (int i = 0; i < nums.Length; i++){
            nums[i] = i + 5;
        }
        strings[0] = "Hello";
        strings[1] = "my";
        strings[2] = "name";
        strings[3] = "is";
        strings[4] = "shane";
        strings[5] = "I wrote";
        strings[6] = "this";

        for (int i = 0; i < nums.Length; i++)
            Debug.Log(nums[i]);
        for (int i = 0; i < strings.Length; i++)
            Debug.Log(strings[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
