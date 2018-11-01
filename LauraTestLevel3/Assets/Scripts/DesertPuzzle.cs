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
        float redDistance = Vector3.Distance(redSpot.position, redObject.transform.position);//calculate distance between spot and object
        if ((redObject.transform.position.y >= redSpot.position.y) &&(redObject.transform.position.x >= redSpot.position.x) && (redDistance < 3f))
        {
            redSolved = true;
        }
        //check if blue is in place
        float blueDistance = Vector3.Distance(blueSpot.position, blueObject.transform.position);//calculate distance between spot and object
        if ((blueObject.transform.position.y >= blueSpot.position.y) && (blueObject.transform.position.x >= blueSpot.position.x) && (blueDistance < 3f))
        {
           blueSolved = true;
        }
        //check if yellow is in place
        float yellowDistance = Vector3.Distance(yellowSpot.position, yellowObject.transform.position);//calculate distance between spot and object
        if ((yellowObject.transform.position.y >= yellowSpot.position.y) && (yellowObject.transform.position.x >= yellowSpot.position.x) && (yellowDistance < 3f))
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
