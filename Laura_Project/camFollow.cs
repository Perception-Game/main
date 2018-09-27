using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*camFollow
 * Camera follows the cursor 
 by Laura Amoroso
 */
public class camFollow : MonoBehaviour
{
//variables for horizontal and vertical speeds
    public float speedH = 2.0f;
    public float speedV = 2.0f;
//variables for camera rotation
    private float rotateV = 0.0f;
    private float rotateH = 0.0f;

    void Start()
    {
    }

    //Update the camera view from the mouse input
    void Update()
    {
        rotateV += speedH * Input.GetAxis("Mouse X");
        rotateH -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(rotateH, rotateV, 0.0f);
    }
}
