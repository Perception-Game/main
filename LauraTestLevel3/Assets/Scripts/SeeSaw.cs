using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* class SeeSaw
 * by Laura Amoroso
 * This scipt is a component the player asset.
 * This is supposed to boost the player upwards when a rock or
 * other object is placed on the other end of the seesaw.
 * 
 *
 * */

public class SeeSaw : MonoBehaviour {

    public Transform Box1; //one end of seesaw
    public Transform Box2; //other end of seesaw
    
	
	void Start () {
		
	}
	
	
	void Update () {

        // DistanceBox1 = Vector3.Distance(GameObject.FindGameObjectWithTag("Clickable").position, Box1.position);//calculate distance between any object and Box1

        if (transform.position.y >= Box1.position.y && transform.position.x >= Box1.position.x)//if player is on top of Box1 end of seesaw
        {
            Debug.Log("Player above box1");
        }

        if (transform.position.y >= Box2.position.y && transform.position.x >= Box2.position.x)//if player is on top of Box2 end of seesaw
        {
            Debug.Log("Player above box2");
        }
    }
}
