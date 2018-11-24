using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Public class BlueGlow
 * This script makes the blue lion statue glow ble when the blue item is brought to it.
 * This is to be attached to the BlueSphere Object.
 * Made by Laura Amoroso
 * */
public class BlueGlow : MonoBehaviour
{

    GameObject blueObject;
    public Transform blueSpot;

    void Start()
    {
        blueObject = GameObject.FindWithTag("Blue");
    }


    void Update()
    {
        float distance = Vector3.Distance(blueSpot.position, blueObject.transform.position);//calculate distance between spot and object
        float xdistance = (blueSpot.position.x - blueObject.transform.position.x);

        //check if blue is in place
        if ((blueObject.transform.position.y >= blueSpot.position.y) && (xdistance < 2f ) && (distance < 3f))
        {
            Behaviour halo = (Behaviour)gameObject.GetComponent("Halo");
            halo.enabled = true; //enable the blue glow
        }
    }
}
