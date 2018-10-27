using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertPuzzle : MonoBehaviour {

    GameObject redObject;
    public Transform redSpot;
    public Transform redSphere; 
    bool redSolved = false;

    GameObject blueObject;
    public Transform blueSpot;
    bool blueSolved= false;

    GameObject yellowObject;
    public Transform yellowSpot;
    bool yellowSolved = false;

     void Start () {
        redSolved = false;
        blueSolved = false;
        yellowSolved = false; 
        redObject = GameObject.FindWithTag("Red");
        blueObject = GameObject.FindWithTag("Blue");
        yellowObject = GameObject.FindWithTag("Yellow");
    }
	
	void Update () {
        //check if red is in place
        if ((redObject.transform.position.y >= redSpot.position.y) &&(redObject.transform.position.x >= redSpot.position.x))
        {
            redSolved = true;
        }
        //check if blue is in place
        if ((blueObject.transform.position.y >= blueSpot.position.y) && (blueObject.transform.position.x >= blueSpot.position.x))
        {
           blueSolved = true;
        }
        //check if yellow is in place
        if ((yellowObject.transform.position.y >= yellowSpot.position.y) && (yellowObject.transform.position.x >= yellowSpot.position.x))
        {
            yellowSolved = true;
        }
        //puzzle solved and bars disappear when all colors are in place
        if ((redSolved == true) && (blueSolved == true) && (yellowSolved == true))
        {
            Destroy(this.gameObject); //remove bars
        }
    }
}
