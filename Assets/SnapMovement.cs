using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapMovement : MonoBehaviour
{
    Vector3 startPos = new Vector3();
    Vector3 endPos = new Vector3();
    float fraction = 0;
    bool moving = false;

    public GameObject rightCol;
    public GameObject rearCol;
    public GameObject leftCol;
    public GameObject frontCol;

    void Start()
    {


    }

    void Update()
    {
        
        

        if (Input.GetKey("d") && !moving)
        {
            if (!rightCol.GetComponent<WallDetector>().contact)
            {
                startPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                endPos = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
                fraction = 0;
                moving = true;
            }
        }

        if (Input.GetKey("a") && !moving)
        {
            if (!leftCol.GetComponent<WallDetector>().contact)
            {
                startPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                endPos = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
                fraction = 0;
                moving = true;
            }
        }

        if (Input.GetKey("w") && !moving)
        {
            if (!frontCol.GetComponent<WallDetector>().contact)
            {
                startPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
                fraction = 0;
                moving = true;
            }
        }

        if (Input.GetKey("s") && !moving)
        {
            if (!rearCol.GetComponent<WallDetector>().contact)
            {
                startPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);
                fraction = 0;
                moving = true;
            }
        }


        if (moving)
        {
            if (fraction < 1)
            {
                fraction += Time.deltaTime * 7f;
                transform.position = Vector3.Lerp(startPos, endPos, fraction);
            }
        }

        if (transform.position == endPos && moving)
        {
            moving = false;
        }
        
    }

    

  
    
}
