using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);             //If the player presses 'r', then the whole level will reload
        }
    }
}
