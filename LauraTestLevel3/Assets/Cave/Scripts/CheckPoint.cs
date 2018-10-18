using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public ResetCharacter resetChar; 

	// Use this for initialization
	void Start ()
    {
        resetChar = FindObjectOfType<ResetCharacter>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            resetChar.SetSpawnPoint(transform.position);
        }
    }
}
