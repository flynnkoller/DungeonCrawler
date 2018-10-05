using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour {

    public bool contact;

    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }


    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contact");
        contact = true;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

     void OnCollisionExit(Collision collision)
    {
        contact = false;
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

}
