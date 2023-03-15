using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    public float xVector;
    public float yVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xVector = Input.GetAxis("Horizontal") * rotateSpeed;
        yVector = Input.GetAxis("Vertical") * moveSpeed;

        this.transform.Translate(Vector3.forward * yVector * Time.deltaTime);
        this.transform.Rotate(Vector3.up * xVector * Time.deltaTime);


    }
}
