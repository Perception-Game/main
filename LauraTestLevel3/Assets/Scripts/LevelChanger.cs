using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

/*
 * Zach Curll
 * Changes the scene to whatever string is attached to the script.
 * The level changes when the player collides with the Object that is assigned to Portal.
 * Object must have a collider and "isTrigger" must be selected in that objects collider.
 * 
 */


public class LevelChanger : MonoBehaviour {

	//Object the player will collide with to change the level.
	public GameObject portal;
	//Name of the level you wish to go to when the player collides with portal
	public string nextLvl;

	// Use this for initialization
	void Start () 
	{

	}

	//When the player collides with the gameobject this script is attached to the level stated with load.
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(nextLvl);
			//SceneManager.LoadScene("nextLvl");
		}
	}
}
