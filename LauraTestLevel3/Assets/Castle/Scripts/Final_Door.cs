using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Door : MonoBehaviour {

    static bool dragon1;                //This is for the first dragon
    static bool dragon2;                //This is for the second dragon
    GameObject door;                    //This is the door
    // Use this for initialization
    void Start () {
		door = GameObject.FindGameObjectWithTag("FinalDoor");           //This finds the door in the scene
        dragon1 = false;                                                //Set to false until the dragon gets put in the right spot
        dragon2 = false;                                                //Set to false until the dragon gets put in the right spot
    }

    void FixedUpdate()
    {

        if(dragon1) 
        {

            if (dragon2)              
            {
                for (int x = 0; x < 70; x++)                            //It iterates this, so the door opens all the way
                {
                    door.transform.Rotate(0, -1, 0);                    //Opens the door
                }
                dragon1 = false;                                        //prevents this from running again
            }
        }
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon1")
        {
            dragon1 = true;                                             //makes it so the door can open
        }

        if (other.tag == "Dragon2")
        {
            dragon2 = true;                                             //makes it so the door can open
        }
    }
}
