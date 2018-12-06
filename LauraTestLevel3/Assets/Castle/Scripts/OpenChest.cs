using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

    GameObject chest;                               //This is the chest
                      
    // Use this for initialization
    void Start () {
        chest = GameObject.FindGameObjectWithTag("Chest");          //Finds the chest object in the scene
	}

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Animator open = chest.GetComponent<Animator>();                 //Finds the animation of the chest opening
            open.enabled = true;                                            //Starts the animation of the chest opening
            GameObject key = GameObject.FindGameObjectWithTag("Key");       //Finds the key game object
            Destroy(key);                                                   //Deletes the key game object

        }

    }
}
