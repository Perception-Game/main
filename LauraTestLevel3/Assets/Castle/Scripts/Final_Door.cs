using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Door : MonoBehaviour {

    static bool dragon1;
    static bool dragon2;
    GameObject door;
    // Use this for initialization
    void Start () {
		door = GameObject.FindGameObjectWithTag("FinalDoor");
        dragon1 = false;
        dragon2 = false;
    }

    void FixedUpdate()
    {

        if(dragon1)
        {

            if (dragon2)
            {
                for (int x = 0; x < 70; x++)
                {
                    door.transform.Rotate(0, -1, 0);
                }
                dragon1 = false;
            }
        }
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon1")
        {
            dragon1 = true;
        }

        if (other.tag == "Dragon2")
        {
            dragon2 = true;
        }
    }
}
