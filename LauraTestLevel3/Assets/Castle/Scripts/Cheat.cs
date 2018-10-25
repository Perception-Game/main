using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat : MonoBehaviour
{

    GameObject button;
    // Use this for initialization
    void Start()
    {
        button = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int x = 0; x < 6; x++)
            {
                button.transform.Translate(0, -3.7f, 1);
            }

        }
    }
}
