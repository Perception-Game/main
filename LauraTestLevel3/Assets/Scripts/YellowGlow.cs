using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Public class YellowGlow
 * This script makes the yellow lion statue glow yellow when the yellow item is brought to it.
 * This is to be attached to the yellowSphere Object.
 * Made by Laura Amoroso
 * */
public class YellowGlow : MonoBehaviour
{

    GameObject yellowObject;
    public Transform yellowSpot;

    void Start()
    {
        yellowObject = GameObject.FindWithTag("Yellow");
    }


    void Update()
    {
        //check if object is close
        float distance = Vector3.Distance(transform.position, yellowObject.transform.position);//calculate distance between spot and object
        float xdistance = (yellowSpot.position.x - yellowObject.transform.position.x);

        //check if yellow is in place
        if ((yellowObject.transform.position.y >= yellowSpot.position.y) && (xdistance < 2) && (distance < 3f))
        {
            Behaviour halo = (Behaviour)gameObject.GetComponent("Halo");
            halo.enabled = true; //enable the yellow glow
        }
    }
}
