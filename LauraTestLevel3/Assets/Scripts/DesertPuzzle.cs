using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * public class DesertPuzzle
 * This class checks to see if all three colors are in their spot.
 * If they are, the metal bars will disapear and the player
 * will be able to advance to the next level.
 * This must be attached to the metal bars game object
 * Made by Laura Amoroso
 * */
public class DesertPuzzle : MonoBehaviour
{

    GameObject redObject;
    public Transform redSpot;
    public Transform redSphere;
    bool redSolved = false;

    GameObject blueObject;
    public Transform blueSpot;
    bool blueSolved = false;

    GameObject yellowObject;
    public Transform yellowSpot;
    bool yellowSolved = false;

    void Start()
    {
        redSolved = false;
        blueSolved = false;
        yellowSolved = false;
        redObject = GameObject.FindWithTag("Red");
        blueObject = GameObject.FindWithTag("Blue");
        yellowObject = GameObject.FindWithTag("Yellow");
       
    }

    void Update()
    {
        //check if red is in place
        float redDistance = Vector3.Distance(redSpot.position, redObject.transform.position);//calculate distance between spot and object
        float xReddistance = (redSpot.position.x - redObject.transform.position.x);
        if ((redObject.transform.position.y >= redSpot.position.y) && (xReddistance < 2) && (redDistance < 3f))
        {
            redSolved = true;
            Debug.Log("RED in place");
        }
        //check if blue is in place
        float blueDistance = Vector3.Distance(blueSpot.position, blueObject.transform.position);//calculate distance between spot and object
        float xBluedistance = (blueSpot.position.x - blueObject.transform.position.x);
        if ((blueObject.transform.position.y >= blueSpot.position.y) && (xBluedistance < 2) && (blueDistance < 3f))
        {
            blueSolved = true;
            Debug.Log("BLUE in place");
        }
        //check if yellow is in place
        float yellowDistance = Vector3.Distance(yellowSpot.position, yellowObject.transform.position);//calculate distance between spot and object
        float xYellowdistance = (yellowSpot.position.x - yellowObject.transform.position.x);
        if ((yellowObject.transform.position.y >= yellowSpot.position.y) && (xYellowdistance < 2) && (yellowDistance < 3f))
        {
            yellowSolved = true;
            Debug.Log("YELLOW in place");
        }

        //puzzle solved and bars disappear when all colors are in place
        if ((redSolved == true) && (blueSolved == true) && (yellowSolved == true))
        {

                      
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>(); //remove mesh renderer
            meshRenderer.enabled = false;
            MeshCollider meshCollider = GetComponent<MeshCollider>(); //remove collider
            meshCollider.enabled = false;

        }
    }
}
