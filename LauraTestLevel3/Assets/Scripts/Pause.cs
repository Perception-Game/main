
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * public class Pause
 * Pausing the game when player hits P. 
 * Attach this code to any game object then drag Player object into it. 
 * made by Laura Amoroso
 * */

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(true);
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
        Time.timeScale = 0;//timescale is set to 0 to diable scripts
        pausePanel.SetActive(true);
        

    }
    private void ContinueGame()
    {
        Time.timeScale = 1; //scripts work again
        pausePanel.SetActive(false);
        
    }
}