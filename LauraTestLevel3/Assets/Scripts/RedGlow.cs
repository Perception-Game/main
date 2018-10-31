using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Public class RedGlow
 * This script makes the red lion statue glow red when the red item is brought to it.
 * This is to be attached to the redSphere Object. 
 * Made by Laura Amoroso
 * */
public class RedGlow : MonoBehaviour {

    GameObject redObject;
    public Transform redSpot;
    
    void Start () {
        redObject = GameObject.FindWithTag("Red");
    }
	
	
	void Update () {
        //check if object is close
        float distance = Vector3.Distance(transform.position, redObject.transform.position);//calculate distance between spot and object
        Debug.Log(distance);
        //check if red is in place
        if ((redObject.transform.position.y >= redSpot.position.y) && (redObject.transform.position.x >= redSpot.position.x) && (distance < 3f))
        {
            Behaviour halo = (Behaviour)gameObject.GetComponent("Halo");
            halo.enabled = true; //enable the red glow
        }
    }
}
