using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * Zach Curll
 * 
 * Script that resets a character to a specific respawnlocation once they come in contact with
 * a collider that they shouldnt. There is also a counter that is set so if the player fails
 * 5 times the level will completely reset.
 * */
public class ResetCharCheckPointOne : MonoBehaviour {


	//The object that will cause the player to fail/die
    public GameObject lava;

	//Where the player will respawn once failing/dieing
    private Vector3 respawnPoint;
    public GameObject player;

	//Check point
    public GameObject Checkpoint;

	//Counter to represent the number of times the user can die/fail before the level resets
    public int deaths;

    // Use this for initialization
    void Start()
    {
        deaths = 0;
        respawnPoint = Checkpoint.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

		//if the counter (death) reaches 5 or more the level will reset
        if(deaths >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
		//if the player fails/dies (collides with the object they shouldnt collide with) 
		//The counter is increased and they are sent back to the respawn point for that specific checkpoint
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = respawnPoint;
            deaths++;
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    
}
