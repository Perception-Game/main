using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* class SunIsClose
 * by Laura Amoroso
 * This scipt is a component to the door asset.
 * The Sun and Lion are to be attached variables. 
 * This is because the measure ment between the Sun and Lion statue
 * will open the door and solve the "puzzle"
 * The sound of an open door played as well.
 * */

public class SunIsClose : MonoBehaviour {

    public Transform Sun;
    public Transform Lion;
    float distance;
    public float minDistance = 3f; //distance required 
    private Animator doorAnimation; //animation variable
    AudioSource doorOpenSound; 
    

    void Start()
    { 
        doorAnimation = GetComponent<Animator>();//get animation
        doorOpenSound = GetComponent<AudioSource>(); //get sound effect
    }



    void Update () {
        distance = Vector3.Distance(Lion.position, Sun.position);//calculate distance between Sun and Lion

        if (distance < minDistance)
        {
            doorAnimation.SetBool("open", true); //door opened
            doorOpenSound.Play(0); //door opening sound effect
            Debug.Log("Puzzle one soloved. Good work.");
        }
       

    }

}
