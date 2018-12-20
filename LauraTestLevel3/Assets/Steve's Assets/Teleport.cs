using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    GameObject mainCamera;
    public Transform waypoint, waypoint2, waypoint3;
    Vector3 loc, loc2, loc3;
	void Start () {
        mainCamera = GameObject.Find("Player");
        loc = new Vector3(waypoint.position.x, waypoint.position.y, waypoint.position.z);
        loc2 = new Vector3(waypoint2.position.x, waypoint2.position.y, waypoint2.position.z);
        loc3 = new Vector3(waypoint3.position.x, waypoint3.position.y, waypoint3.position.z);
    }
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            mainCamera.transform.position = loc;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            mainCamera.transform.position = loc2;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            mainCamera.transform.position = loc3;
        }

    }

}
