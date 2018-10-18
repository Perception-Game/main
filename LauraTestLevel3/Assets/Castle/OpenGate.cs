using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {

    GameObject gate;

	// Use this for initialization
	void Start () {
        gate = GameObject.FindGameObjectWithTag("Gate");
	}

    public void OnTriggerEnter(Collider other)
    {
        gate.transform.Translate(0, 0, Time.deltaTime);
        Debug.Log("works");
    }
}
