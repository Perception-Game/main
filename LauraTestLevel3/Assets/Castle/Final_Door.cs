using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Door : MonoBehaviour {

    int num;
    bool dragon1;
    bool dragon2;
    GameObject door;
    // Use this for initialization
    void Start () {
        num = 0;
		door = GameObject.FindGameObjectWithTag("FinalDoor");
        dragon1 = true;
        dragon2 = true;
    }

    void FixedUpdate()
    {

        if(num == 2)
        {
                Debug.Log("4");
            num++;
                 
                for (int x = 0; x < 70; x++)
                {
                    door.transform.Rotate(0, 1, 0);
                }
        }
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon1" && dragon1)
        {
            num++;
            dragon1 = false;
            Debug.Log(num);
        }

        if (other.tag == "Dragon2" && dragon2)
        {
            if(!dragon1)
            { num = 2; }
            dragon2 = false;
            Debug.Log(num);
        }
    }
}
