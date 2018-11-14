﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDrop : MonoBehaviour {

   // public Vector3 pos;
    public GameObject rock;
    private bool enter;
    public AudioClip caveIn;
    private AudioSource source;
    private bool played;

    // Use this for initialization
    void Start ()
    {
        played = false;
        enter = false;
        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (enter)
        {
            rock.transform.position = new Vector3(-843.5089f, 255.5852f, -128.6557f);
            if (!played)
            {
                source.PlayOneShot(caveIn);
                played = true;
            }
         
        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enter = true;
        }
    }
}