using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityStandardAssets.Characters.FirstPerson;

/**
 * This class is used to make it appear as if the player is under lava
 * once they enter the attached collider.
 * Once the player leaves the attached collider the screen will appear as normal.
 * 
 * */
public class ChangeUnderLava : MonoBehaviour {

	//PPP to set the screen as
	//Normal should be used as the normal
	//fx should be used as the new
	public PostProcessingProfile normal, fx;
	private PostProcessingBehaviour camImageFx;

	public bool swim = false;

	private GameObject player;
	private float defWalkspeed, defJumpspeed, defRunspeed, defGravityMultiplier, defStickToGroundForce;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindWithTag("MainCamera");
		camImageFx = FindObjectOfType<PostProcessingBehaviour> ();
	}

	void Update()
	{

	}


	void OnTriggerEnter(Collider other)
	{
		GameObject p = other.gameObject;

		if(p.tag == "Player")
		{
			//	test = true;
			camImageFx.profile = fx;
			defWalkspeed = p.GetComponent<FirstPersonController> ().m_WalkSpeed;
			defRunspeed = p.GetComponent<FirstPersonController> ().m_RunSpeed;
			defJumpspeed = p.GetComponent<FirstPersonController> ().m_JumpSpeed;
			defGravityMultiplier = p.GetComponent<FirstPersonController> ().m_GravityMultiplier;
			defStickToGroundForce = p.GetComponent<FirstPersonController> ().m_StickToGroundForce;
			p.GetComponent<FirstPersonController> ().m_WalkSpeed = 1.0f;
			p.GetComponent<FirstPersonController> ().m_RunSpeed = 2.0f;
			p.GetComponent<FirstPersonController> ().m_JumpSpeed = 1f;
			p.GetComponent<FirstPersonController> ().m_GravityMultiplier = 0.0f;
			p.GetComponent<FirstPersonController> ().m_StickToGroundForce = 2.0f;

	
			swim = true;

		}

	}

	void OnTriggerExit(Collider other)
	{
		GameObject p = other.gameObject;

		if(p.tag == "Player")
		{
			//test = false;
			camImageFx.profile = normal;

			p.GetComponent<FirstPersonController> ().m_WalkSpeed = defWalkspeed;
			p.GetComponent<FirstPersonController> ().m_RunSpeed = defRunspeed;
			p.GetComponent<FirstPersonController> ().m_JumpSpeed = defJumpspeed;
			p.GetComponent<FirstPersonController> ().m_GravityMultiplier = defGravityMultiplier;
			p.GetComponent<FirstPersonController> ().m_StickToGroundForce = defStickToGroundForce;

			if (swim)
			{
				Vector3 currPos = player.transform.position;
				if (currPos.y < 248.0f) 
				{
					//player.GetComponent<Rigidbody> ().useGravity;
				}
				if (currPos.y > 248.356)
				{
					player.GetComponent<FirstPersonController> ().m_GravityMultiplier = defGravityMultiplier;
				}
			}

			//p.transform.position.y = 248.365f;	
			//Rigidbody rb = p.GetComponent<Rigidbody> ();
			//rb.constraints = RigidbodyConstraints.FreezePositionY;
					
			//if (Input.GetKeyDown (KeyCode.Space)) 
			//{
				//rb.constraints = RigidbodyConstraints.None;
			//}
		
		}

	}

}
