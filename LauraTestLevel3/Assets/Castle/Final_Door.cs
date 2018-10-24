using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Door : MonoBehaviour {

    int num = 0;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon")
        {
            num++;
            if(num == 2)
            {
                GameObject door = GameObject.FindGameObjectWithTag("FinalDoor");
                for (int x = 0; x < 70; x++)
                {
                    door.transform.Rotate(0, 1, 0);
                }
            }

        }

    }
}
