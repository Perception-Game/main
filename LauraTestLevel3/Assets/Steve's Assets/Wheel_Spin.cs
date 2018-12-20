using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel_Spin : MonoBehaviour {

    public Transform wheel1;
    public Transform wheel2;
    public Transform wheel3;
    public Transform wheel4;
    public float tran_speed = 850f;
	
	// Update is called once per frame
	void Update () {
        wheel1.Rotate(Vector3.down, tran_speed * Time.deltaTime);
        wheel2.Rotate(Vector3.down, tran_speed * Time.deltaTime);
        wheel3.Rotate(Vector3.down, tran_speed * Time.deltaTime);
        wheel4.Rotate(Vector3.down, tran_speed * Time.deltaTime);
    }
}
