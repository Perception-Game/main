using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{

    GameObject gate;                            //This is the gate
    GameObject door;                            //This is the door

    // Use this for initialization
    void Start()
    {
        gate = GameObject.FindGameObjectWithTag("Gate");    //Finds the gate in the scene
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coins")
        {
            for (int x = 0; x < 5; x++)
            {   
                gate.transform.Translate(0, 0, -1);             //if "coins" hit it, The gate will move upwards a bit

            }
        }

        if (other.tag == "Sword")
        {
            door = GameObject.FindGameObjectWithTag("Door");                  //Finds the door in the scene
            for (int x = 0; x < 30; x++)
            {
                door.transform.Rotate(0, 1, 0);                              //Opens the door
            }
            GameObject key = GameObject.FindGameObjectWithTag("Key");       //Finds the key game object
            Renderer rend = key.GetComponent<Renderer>();                   //Gets the rendering component for the key
            rend.enabled = true;                                            //Makes the key visable in the scene
            Destroy(GameObject.FindGameObjectWithTag("Sword"));             //Deletes the sword game object
        }
    }
}
