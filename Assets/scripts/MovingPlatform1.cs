using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform1 : MonoBehaviour
{
    private Vector3 startPosition;
    private float moveDistance = 30;
    public int speed = 3;
    public bool forward = true;
    public int rotateTimeout;
    private int timeOutMax;
    //private bool rotating = false;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        timeOutMax = rotateTimeout;
    }

    // Update is called once per frame
    void Update()
    {
        if (forward)
        {
            transform.position += new Vector3(speed*.001f, 0f, 0f);

            if (transform.position.x >= moveDistance)
            {
                forward = false;
            }
        }
        else
        {
            transform.position -= new Vector3(speed * .01f, 0f, 0f);
            if (transform.position.x <= startPosition.x)
            {
                forward = true;
            }
        }
        rotateTimeout--;
        if (rotateTimeout < 0){
            Quaternion target = Quaternion.Euler(180.0f, 0.0f, 0.0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
            if (transform.rotation == target){
                rotateTimeout = timeOutMax;
            }
        }

    }
}
