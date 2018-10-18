using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour {

    private Vector3 startPos;
    private Vector3 currPos;
    public GameObject rock;
	// Use this for initialization
	void Start ()
    {
        startPos = rock.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    { 
        currPos = rock.transform.position;
            if (currPos != startPos)
            {
                rock.GetComponent<Rigidbody>().isKinematic = false;
            }
     
	}

   
}
