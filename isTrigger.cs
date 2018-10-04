using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour {

    OpenDoor doorScript;
	// Use this for initialization
	void Start () {
        GameObject theDoor = GameObject.FindGameObjectWithTag("Door");
        doorScript = theDoor.GetComponent<OpenDoor>();
        
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("yes");
        doorScript.open = true;
        
    }


}
