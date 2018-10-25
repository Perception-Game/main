using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_ : MonoBehaviour
{


    Animator animator;
    bool glassOpen;
    public AudioClip GlassSound;

    void Start()
    {

        glassOpen = false;
        animator = GetComponent<Animator>();


    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(GlassSound);

            glassOpen = true;
            GlassControl("Open");

        }
    }


    void OnTriggerExit(Collider col)
    {

        if (glassOpen)
        {
            while(col.gameObject.tag == "Player") {  }
            
             gameObject.GetComponent<AudioSource>().PlayOneShot(GlassSound);

             glassOpen = false;
             GlassControl("Close");
            
        }
    }


    void GlassControl(string direction)
    {

        animator.SetTrigger(direction);

    }

}