using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chop_tree : MonoBehaviour {


    public Object da_wood;
    public Rigidbody position_holder;
    public Collider da_tree;
    public bool do_once = true;
    private Vector3 pos;
    //public Rigidbody wood_rigid;

    void Start()
    {
        pos = new Vector3(position_holder.position.x, position_holder.position.y, position_holder.position.z);
    }

    void OnCollisionEnter(Collision t)
    {
        if (t.gameObject == da_tree.gameObject && do_once)
        {
            Debug.Log("We have hit the tree");
            Instantiate(da_wood, pos, Quaternion.identity);
            //da_wood.position = new Vector3(position_holder.position.x, position_holder.position.y, position_holder.position.z);
            do_once = false;
            //wood_rigid.constraints = RigidbodyConstraints.None;
        }
    }
}
