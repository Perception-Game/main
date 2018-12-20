using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    GameObject wall;
    // Use this for initialization
    void Start()
    {
        wall = GameObject.FindGameObjectWithTag("Wall");     //Finds the wall object to get to the next room
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")              //if the player hits this object
        {
            Destroy(wall);                      //delete the wall
            Destroy(gameObject);                //delete this object
        }
            

    }
}
