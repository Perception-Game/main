using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Resets the player to checkpoint 2 if they fail the the second rock puzzle and fall into the lava.
 * If the player fails 5 times the level will reset and the player will be placed
 * at the start.
 * lava - GameObject that will be the lava that is below the player.
 * Checkpoint - The place that marks the checkpoint that the character will be reset to.
 * 
 * */
public class ResetCharacterCheckPointTwo : MonoBehaviour {

	public GameObject lava;
	private Vector3 respawnPoint;
	public GameObject player;
	public GameObject Checkpoint;
	public int deaths;

	// Use this for initialization
	void Start()
	{
		deaths = 0;
		// player = GameObject.FindWithTag("MainCamera");
		respawnPoint = Checkpoint.transform.position;
		// respawnPoint = player.transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		if(deaths >= 5)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			player.transform.position = respawnPoint;
			deaths++;
			// SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}


}
