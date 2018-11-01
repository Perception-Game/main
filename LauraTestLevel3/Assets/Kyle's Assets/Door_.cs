using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_ : MonoBehaviour
{


    Animator animator;
    bool doorOpen;
    public AudioClip DoorSound;

    void Start()
    {

        doorOpen = false;
        animator = GetComponent<Animator>();


    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(DoorSound);

            doorOpen = true;
            DoorControl("Open");

        }
    }


    void OnTriggerExit(Collider col)
    {

        if (doorOpen)
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(DoorSound);

            doorOpen = false;
            DoorControl("Close");

        }
    }


    void DoorControl(string direction)
    {

        animator.SetTrigger(direction);

    }

}