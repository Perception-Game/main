using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_bridge : MonoBehaviour {

    //public Collider spot;
    //public Rigidbody rigPos;
    public MeshRenderer bridge_mesh;
    public BoxCollider bridge_collider;
    //private Vector3 pos;
    bool doOnce = true;

	void Start () {
        //pos = new Vector3(rigPos.position.x, rigPos.position.y, rigPos.position.z);
	}

    void OnTriggerEnter(Collider t)
    {
        if (t.tag == "Small_Tree" && doOnce)
        {
            Debug.Log("There should be a bridge now.");
            bridge_mesh.enabled = true;
            bridge_collider.enabled = true;
            doOnce = false;
        }
    }
}
