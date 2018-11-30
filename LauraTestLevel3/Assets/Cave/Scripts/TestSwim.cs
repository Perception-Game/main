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
public class TestSwim : MonoBehaviour {

	//PPP to set the screen as
	//Normal should be used as the normal
	//fx should be used as the new
	public PostProcessingProfile normal, fx;
	private PostProcessingBehaviour camImageFx;


	//private FirstPersonController _firstPersonController;
	//private CharacterController _characterController;
	//private Camera _camera;
	private float defWalkspeed, defJumpspeed, defRunspeed, defGravityMultiplier, defStickToGroundForce;
	//public bool test = false;

	// Use this for initialization
	void Start () 
	{
		camImageFx = FindObjectOfType<PostProcessingBehaviour> ();


	//	_firstPersonController = GetComponent<FirstPersonController>();
	//	_characterController = GetComponent<CharacterController>();
	//	Transform fpChar = transform.Find("FirstPersonCharacter");
		//_camera = fpChar.GetComponent<Camera>();
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


		//	p.GetComponent<Rigidbody> ().drag = 500;
		//	p.GetComponent<Rigidbody>().useGravity = false;
		//	p.GetComponent<Rigidbody>().velocity = new Vector3(0f, -.5f, 0f);
		//	p.GetComponent<Animator>().SetBool("IsSwimming", true);
			//p.GetComponent<MouseControls>().isSwimming = true;
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
		}

	}

}
