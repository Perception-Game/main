using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_wall : MonoBehaviour {

    public GameObject p;
    public Rigidbody wall;
	
    void OnTriggerEnter(Collider t)
    {
        if (t.name == "Player")
            wall.useGravity = true;
    }
}
