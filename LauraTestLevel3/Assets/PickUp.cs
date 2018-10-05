using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Class PickUp
 * created by Zach Reynolds
 * Used for picking up an object and keeping it at its current size.
 * Code should be a componant for any object that can be picked up.
 * Make sure "Player" is the tag of the player
 */

public class PickUp : MonoBehaviour
{

    bool holding = false;
    GameObject player;
    Vector3 vec;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");    //This finds the PLayer object

    }


    void OnMouseDown()
    {
        float dis = Vector3.Distance(player.transform.position, this.transform.position);
        dis = (dis % 10 * .03f); //this is the line of code for scaling. this line needs to be changed
        Debug.Log(dis);
        Vector3 newScale = transform.localScale;
        newScale = newScale * dis;
        transform.position = player.transform.position + (player.transform.forward * 2.0f); // to move the object in front of the player
        transform.localScale = newScale;
        transform.parent = player.transform;    //To move the object with the player

        holding = true;
    }

     void Update()
    {
        if (holding == true && Input.GetMouseButtonDown(1))//right click mouse to drop item
        {
            transform.parent = null; //drop object
            Debug.Log("Right clicked to drop item.");
            holding = false; 
        }
    }


}