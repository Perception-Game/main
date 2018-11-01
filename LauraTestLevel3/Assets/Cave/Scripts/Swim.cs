using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityStandardAssets.Characters.FirstPerson;

public class Swim : MonoBehaviour {





	public GameObject lava;
	private FirstPersonController _firstPersonController;
	private Camera _camera;
	private CharacterController _characterController;
	private float defWalkspeed, defJumpspeed, defRunspeed, defGravityMultiplier, defStickToGroundForce;
	private float newWalkspeed, newJumpspeed, newRunspeed, newGravityMultiplier, newStickToGroundForce;
	private AudioClip defJumpsound;
	private AudioClip defLandSound;
	private AudioClip[] defFootstepSounds;
	private AudioClip newJumpsound;
	private AudioClip newLandSound;
	private AudioClip[] newFootstepSounds;
	//public float _upDownSpeed = 1.0f;
	Vector3 mv;

	// Use this for initialization
	void Start () 
	{
		_firstPersonController = GetComponent<FirstPersonController>();
		_characterController = GetComponent<CharacterController>();
		Transform fpChar = transform.Find("FirstPersonCharacter");
		_camera = fpChar.GetComponent<Camera>();

		mv = _firstPersonController.m_MoveDir;
		defWalkspeed = _firstPersonController.m_WalkSpeed;
		defRunspeed = _firstPersonController.m_RunSpeed;
		defJumpspeed = _firstPersonController.m_JumpSpeed;
		defGravityMultiplier = _firstPersonController.m_GravityMultiplier;
		defStickToGroundForce = _firstPersonController.m_StickToGroundForce;
		newWalkspeed = 1.0f;
		newJumpspeed = 0.0f;
		newRunspeed = 2.0f;	
		newGravityMultiplier = 0.1f;
		newStickToGroundForce = 0.0f;

	}
	
	// Update is called once per frame	
	void Update ()
	{
		//_firstPersonController.GetComponent<Rigidbody>().drag = 5;
		//_firstPersonController.GetComponent<Rigidbody>().useGravity - false;
		//_firstPersonController.transform.position.y = 2;
		//_firstPersonController.m_GravityMultiplier = newGravityMultiplier;	
		//_firstPersonController.m_StickToGroundForce = newStickToGroundForce;	

		//_firstPersonController.attachedRigidbody.useGravity = false;

		/*
		if(Input.GetKeyDown(KeyCode.E))
		{
			mv.y = _upDownSpeed;
		}

		if(Input.GetKeyDown(KeyCode.Q))
		{
			mv.y = - _upDownSpeed;
		}
		*/

		_firstPersonController.m_WalkSpeed = newWalkspeed;
		_firstPersonController.m_JumpSpeed = newJumpspeed;
		_firstPersonController.m_RunSpeed = newRunspeed;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			_firstPersonController.m_WalkSpeed = newWalkspeed;
			_firstPersonController.m_JumpSpeed = newJumpspeed;
			_firstPersonController.m_RunSpeed = newRunspeed;
			//player.transform.position = respawnPoint;
			// SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	/*
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == "Player")
		{
			_firstPersonController.m_WalkSpeed = newWalkspeed;
			_firstPersonController.m_JumpSpeed = newJumpspeed;	
			_firstPersonController.m_RunSpeed = newRunspeed;

		}
	}
	

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == "Player")
		{
			_firstPersonController.m_WalkSpeed = defWalkspeed;
			_firstPersonController.m_JumpSpeed = defJumpspeed;	
			_firstPersonController.m_RunSpeed = defRunspeed;

		}
	}

*/


}