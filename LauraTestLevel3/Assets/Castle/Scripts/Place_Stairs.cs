using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Stairs : MonoBehaviour {
    public GameObject placeStairs;              //This is the mark for where to place the stairs
    public GameObject stairs;                   //This is the first stairs
    public GameObject stairs2;                  //This is the second stairs
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
             Instantiate(stairs, new Vector3(276.84f, 173.7f, 145.22f), placeStairs.transform.rotation);        //This puts the first stairs in the place that is specified in the PlaceStairs
        }

        if (other.tag == "Barrel")                                                                          //This whole thing will make the stairs appear 
        {

            GameObject grandChild1;                                                                         //This is the first grandchild
            GameObject grandChild2;                                                                         //This is the second grandchild
            for (int x = 0; x < 11; x++)                                                                    //There are 11 children for this gameobject
            {
                grandChild1 = stairs2.gameObject.transform.GetChild(x).GetChild(0).gameObject;              //This gets the first grandchild
                grandChild2 = stairs2.gameObject.transform.GetChild(x).GetChild(1).gameObject;              //This gets the second grandchild
                Renderer rend = grandChild1.GetComponent<Renderer>();                                       //This gets the renderer component for the first grandchild
                rend.enabled = true;                                                                        //This makes the object visable
                Renderer rend1 = grandChild2.GetComponent<Renderer>();                                      //This gets the renderer component for the second grandchild
                rend1.enabled = true;                                                                       //This makes the object visable
            }
            

        }
       


    }
}
