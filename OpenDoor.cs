using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {
    //Put the script on the door object

    public bool open = false;  //This determines when the door will open

    
	// Update is called once per frame
	void Update () {
		if (open)
        {
            transform.Rotate(0, 90, 0);
            open = false;
        }
	}
}
