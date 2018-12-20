using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelPush : MonoBehaviour {

    public GameObject p;
    public Transform[] targets;
    public float speed = 75f;
    private int current = 0;
    bool col = false;

	void Start () {
       // p = GameObject.Find("Player");
	}
	
    void OnTriggerEnter(Collider t)
    {
        if (t.name == "Player")
        {
            Debug.Log("We've hit the wheel");
            col = true;
            p.GetComponent<Rigidbody>().useGravity = false;
            p.GetComponent<CharacterController>().enabled = false;
        }
    }

    void Update()
    {
        if (col)
        {
            if (p.transform.position == targets[targets.Length-1].position) // stop when we are at the last spot and turn stuff back on
            {
                col = false;
                p.GetComponent<Rigidbody>().useGravity = true;
                current = 0;
                p.GetComponent<CharacterController>().enabled = true;
            }
            if (p.transform.position != targets[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(p.transform.position, targets[current].position, speed * Time.deltaTime);
                p.GetComponent<Transform>().transform.position = pos;
            }
            else current = current + 1;
        }

    }
}
