using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Public class BlueGlow
 * This script makes the blue lion statue glow ble when the red item is brought to it.
 * This is to be attached to the BlueSphere Object. 
 * Made by Laura Amoroso
 * */
public class BlueGlow : MonoBehaviour
{

    GameObject blueObject;
    public Transform BlueSpot;

    void Start()
    {
        blueObject = GameObject.FindWithTag("blue");
    }


    void Update()
    {
        //check if red is in place
        if ((blueObject.transform.position.y >= BlueSpot.position.y) && (blueObject.transform.position.x >= BlueSpot.position.x))
        {
            Behaviour halo = (Behaviour)gameObject.GetComponent("Halo");
            halo.enabled = true; //enable the blue glow
        }
    }
}
