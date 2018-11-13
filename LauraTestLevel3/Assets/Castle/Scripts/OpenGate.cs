using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{

    GameObject gate;
    GameObject door;
    public PickUp pick;

    // Use this for initialization
    void Start()
    {
        gate = GameObject.FindGameObjectWithTag("Gate");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coins")
        {
            for (int x = 0; x < 5; x++)
            {
                gate.transform.Translate(0, 0, -1);

            }
        }

        if (other.tag == "Sword")
        {
            door = GameObject.FindGameObjectWithTag("Door");
            for (int x = 0; x < 30; x++)
            {
                door.transform.Rotate(0, 1, 0);
            }
            GameObject key = GameObject.FindGameObjectWithTag("Key");
            Renderer rend = key.GetComponent<Renderer>();
            rend.enabled = true;
            pick.DropObject();
            Destroy(GameObject.FindGameObjectWithTag("Sword"));
        }
    }
}
