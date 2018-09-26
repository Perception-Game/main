using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*ObjClicked
 * This is for when a player picks up and carries an item
 * by Laura Amoroso
 */
public class ObjClicked : MonoBehaviour {
    public Vector3 offset; //item offest 
    bool ifClicked = false;
    Vector3 playerPos; 

    void Start () {
       playerPos = GameObject.Find("Player").transform.position; // get player position
    }
	

	void Update () {
	if (ifClicked == true)//keeps item at player's  side
        {
            transform.position = playerPos + offset;
        }
	}

    void OnMouseDown()
    {
        transform.position = playerPos + offset;
        ifClicked = true; 

    }

}
