using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate02 : MonoBehaviour {
    public AudioSource thud;
	// Use this for initialization
	void Start () {
        thud = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter (Collision coll)
    {
        
        if (coll.gameObject.tag == "Wall"){
            thud.Play();

        }


    }
}
