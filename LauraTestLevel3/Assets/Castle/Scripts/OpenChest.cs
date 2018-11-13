using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

    GameObject chest;
    public PickUp pick;
    // Use this for initialization
    void Start () {
        chest = GameObject.FindGameObjectWithTag("Chest");
	}

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Animator open = chest.GetComponent<Animator>();
            open.enabled = true;
            GameObject key = GameObject.FindGameObjectWithTag("Key");
            pick.DropObject();
            Destroy(key);

        }

    }
}
