using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *Zach Curll
 *Zach Reynolds
 *Laura Amoroso
 * Allows the player to pick up and object and scale it based on their distance.
 * They player picks the object up by pressing E while their crosshair is on the object.
 * The player can drop the object by pressing E again to release the object.
 * The script "Pickupable" MUST be attached to any object you wish to pick up.
 * This script MUST be attached to the PLAYER object for it to be used, do NOT attach this script to the object!!
 */
public class PickUp : MonoBehaviour
{

    GameObject mainCamera;
    GameObject pickedUpObject;
    bool carryingObject;
    public float distance;
    //variable to be adjusted to make carrying an object feel smoother
    public float smooth;



    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        //If the object is being carried, check if it needs to be droped, else pick the object up if needed
        if (carryingObject)
        {
            Carry(pickedUpObject);
            CheckDrop();
        }
        else
        {
            Pickup();
        }

    }

    //Carry an object
    void Carry(GameObject o)
    {
        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
    }

    //pick an object up
    void Pickup()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Center of the screen
            int x = Screen.width / 2;
            int y = Screen.height / 2;


            Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    float armLength = 5; // the arm length of the character, or where the object travels to after grabbing
                    float dis = Vector3.Distance(p.transform.position, transform.position);//this calculates the distnce the object is from the player
                    float disDiff = armLength / dis; // the delta variable of the change in distance
                    p.transform.localScale = p.transform.localScale * disDiff;//Scale object by delta
                    p.transform.position = new Vector3(0, 0, armLength); // Bring the object to the armlength
                    carryingObject = true;
                    pickedUpObject = p.gameObject;

                }
            }
        }
    }

    //Check if the object should be dropped
    void CheckDrop()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DropObject();
        }
    }

    //drop an object
    void DropObject()
    {
        carryingObject = false;
        pickedUpObject = null;
    }
}
