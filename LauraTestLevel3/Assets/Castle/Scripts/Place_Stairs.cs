using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Stairs : MonoBehaviour {
    public GameObject placeStairs;
    public GameObject stairs;
    public GameObject stairs2;
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
             Instantiate(stairs, new Vector3(276.84f, 173.7f, 145.22f), placeStairs.transform.rotation);
        }

        if (other.tag == "Barrel")
        {

            GameObject grandChild1;
            GameObject grandChild2;
            for (int x = 0; x < 11; x++)
            {
                grandChild1 = stairs2.gameObject.transform.GetChild(x).GetChild(0).gameObject;
                grandChild2 = stairs2.gameObject.transform.GetChild(x).GetChild(1).gameObject;
                Renderer rend = grandChild1.GetComponent<Renderer>();
                rend.enabled = true;
                Renderer rend1 = grandChild2.GetComponent<Renderer>();
                rend1.enabled = true;
            }
            

        }
       


    }
}
