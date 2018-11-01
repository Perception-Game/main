using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ChangeUnderLava : MonoBehaviour {

	public PostProcessingProfile normal, fx;

	private PostProcessingBehaviour camImageFx;

	// Use this for initialization
	void Start () 
	{
		camImageFx = FindObjectOfType<PostProcessingBehaviour> ();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
			{
			camImageFx.profile = fx;
			}

	}

	void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Player"))
			{
				camImageFx.profile = normal;
			}

			}

}
