using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour {

    public bool contact;
    
    public void OnCollisionEnter(Collision collision)
    {
        contact = true;
    }

     void OnCollisionExit(Collision collision)
    {
        contact = false;
    }

}
