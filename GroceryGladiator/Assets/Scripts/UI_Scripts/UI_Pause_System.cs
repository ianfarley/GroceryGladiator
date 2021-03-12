using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Pause_System : MonoBehaviour
{
    public static bool isPaused;
    public GameObject pausePanel;
    void Start()
    {
        isPaused = false;
        pausePanel.SetActive(false);

        //Useful when player restarts
        if(isPaused == false)
        {
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false)
            {
                isPaused = true;

                //Stops everything!
                Time.timeScale = 0; 

                //Open pause panel
                pausePanel.SetActive(true); 

                //Disables player movement controls
                PlayerMovements.canMove = false; 
            }

            else if(isPaused == true)
            {
                isPaused = false;

                //Resumes everything
                Time.timeScale = 1;

                //Close pause panel
                pausePanel.SetActive(false);

                //Re-enables player movement controls
                PlayerMovements.canMove = true;
            }
        }
        
    }
}
