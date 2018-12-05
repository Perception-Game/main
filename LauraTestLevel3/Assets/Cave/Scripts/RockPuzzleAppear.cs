using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Adds the rock puzzle to the scene once the player brings the bucket to the lion statue.
 * The rock puzzle will allow the player to reach the upper part of the cave which
 * leads to the exit.
 * Rock1-Rock8 : Game objects (rocks) that will be used in the puzzle.
 * 
 * */

public class RockPuzzleAppear : MonoBehaviour {


	private GameObject player;
	public GameObject sphere;
	public GameObject rock1;
	public GameObject rock2;
	public GameObject rock3;
	public GameObject rock4;
	public GameObject rock5;
	public GameObject rock6;
	public GameObject rock7;
	public GameObject rock8;
	private float distance;
	public GameObject lion;
	public float minDistance = 2f;



	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindWithTag("MainCamera");
	}

	// Update is called once per frame
	void Update ()
	{   
		//Checks if the bucket is placed near the lion statue
		//If it is it calls AddRocks()
		distance = Vector3.Distance(sphere.transform.position, lion.transform.position);

		if (distance < minDistance)
		{
			AddRocks();
		}
	}

	//Rocks are placed in their appriorate place.
	public void AddRocks()
	{
		rock1.transform.position = new Vector3(-869.71f, 248.26f, -144.75f);
		rock2.transform.position = new Vector3(-873.06f, 249.46f, -146.58f);
		rock3.transform.position = new Vector3(-880.45f, 250.54f, -143.82f);
		rock4.transform.position = new Vector3(-875.56f, 251.837f, -146.08f);
		rock5.transform.position = new Vector3(-870.5f, 253.64f, -147.78f);
		rock6.transform.position = new Vector3(-867.93f, 247.25f, -142.76f);
		rock7.transform.position = new Vector3(-866.64f, 246.57f, -138.49f);
		rock8.transform.position = new Vector3(-877.62f, 250.48f, -141.8f);
	}
}
