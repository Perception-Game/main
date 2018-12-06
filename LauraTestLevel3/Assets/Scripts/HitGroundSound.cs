using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * public class HitGroundSound
 * This class plays a sound clip from an audiosource gameObject when
 * the object this code is attached to hits any object with the tag
 * "Wall", the sound bit will play once. It can only replay the sound
 * again after one second as well. 
 * --Step one, attach this code the object you want the sound to come from
 * --Step two, create an audio source on the same object with the desired sound
 * --Step Three, be sure to change audio source to Linear.
 * --Step four, choose the same object as the input for this code.
 * Made by Laura Amoroso
 * */
public class HitGroundSound : MonoBehaviour
{
    public AudioSource thud;
    // Use this for initialization

    float nextSoundTime = 0; // can't play sounds for one seconds

    void Start()
    {
        thud = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision coll)
    {

        if (Time.time >= nextSoundTime)
        {
            if (coll.gameObject.tag == "Wall")
            {
                thud.Play(); //play sound
                nextSoundTime = Time.time + 2; //increment time

            }
        }
    }
}




