using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    GameObject wall;
    // Use this for initialization
    void Start()
    {
        wall = GameObject.FindGameObjectWithTag("Wall");
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(wall);
            Destroy(gameObject);
        }
            

    }
}
