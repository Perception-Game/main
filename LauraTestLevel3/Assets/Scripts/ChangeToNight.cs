using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 *Zach Curll
 * 
 * Changes the seen from day to night whenever the gameobject "sun" is moved.
 * Must attach the script to the object you wish this script to perform on when moved.
 * Must also attach the skybox you want it to change to to the "night" field.
 * Must also attach the object to the "sun" field.
 */
public class ChangeToNight : MonoBehaviour {

    public Material night;
    public GameObject sun;
    public bool moved;

    public Vector3 startPos = new Vector3(50, 54.57f,0.7f);

    // Use this for initialization
    void Start ()
    {
        

	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 sunPos = sun.transform.position;
        if (sunPos != startPos)
        {
            RenderSettings.skybox = night;
        }

    }
}
