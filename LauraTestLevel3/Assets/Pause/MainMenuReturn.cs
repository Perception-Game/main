using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*public class MainMenuReturn
 * Script for the user to travel to the main menu scene
 * Made by Laura Amoroso
 * */
public class MainMenuReturn : MonoBehaviour
{
    public void changeMenuScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
	