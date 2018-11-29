using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

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
