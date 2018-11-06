using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Stairs : MonoBehaviour {
    public GameObject placeStairs;
    public GameObject stairs;
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
            Instantiate(stairs, new Vector3(276.84f, 174.0f, 145.22f), placeStairs.transform.rotation);
        }

        
    }
}
