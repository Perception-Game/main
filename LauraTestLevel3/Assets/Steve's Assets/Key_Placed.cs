using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Placed : MonoBehaviour {

    public Collider mKey;
    public Rigidbody wall;
    public MeshRenderer sKey;
    //public Collider player;
    private bool doOnce = true;
	
    void OnTriggerEnter(Collider t)
    {
        if (t == mKey && doOnce)
        {
            Debug.Log("Key has been placed.");
            Destroy(mKey);
            sKey.enabled = true;
            wall.useGravity = true;
            doOnce = false;
        }
    }
}
