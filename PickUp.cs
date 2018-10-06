using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Zack Reynolds
 */ 

public class PickUp : MonoBehaviour {

	//You'll put this on the object you are going to pick up

	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");	//This finds the PLayer object

	}


	void OnMouseDown () {
		float dis = Vector3.Distance(player.transform.position, this.transform.position);		//this calculates the distnce the object is from the player
		dis = (1f / (dis * .5f)); 						//You're goig to scale the object by this number
		transform.position = player.transform.position + (player.transform.forward * 2.0f);	// to move the object in front of the player
		transform.localScale = transform.localScale * dis;				//Actually scaling the object
	    transform.parent = player.transform;	//To move the object with the player
	}
}
