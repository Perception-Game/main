using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertChangeLevel : MonoBehaviour
{
    /*public class DesertChangeLevel
     * On collison between the player and this NextLevel object,
     * player will move on to next level: Castle
     * Made by Laura Amoroso
     * */

   

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level1");
    }

}
