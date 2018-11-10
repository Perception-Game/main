
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * public class Pause
 * Pausing the game when player hits P. 
 * Attach this code to any game object then drag PauseGUI or Canvas object into it. 
 * made by Laura Amoroso
 * */

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
 
    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!pausePanel.activeInHierarchy)
            {

                PauseGame();
            }
            else if(pausePanel.activeInHierarchy)
            {
                ContinueGame();
            }
        }
    }
    private void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;//timescale is set to 0 to diable scripts
        

        

    }
    private void ContinueGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1; //scripts work again
        
        
    }
}