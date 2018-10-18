using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetCharacter : MonoBehaviour {

    public GameObject lava;
    private Vector3 respawnPoint;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindWithTag("MainCamera");
       // respawnPoint = player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = respawnPoint;
           // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void SetSpawnPoint(Vector3 newPos)
    {
        respawnPoint = newPos;
    }
}
