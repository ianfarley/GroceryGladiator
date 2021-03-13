using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ResumeButton : MonoBehaviour
{
    public GameObject pausePanel;

    public void OnResumeButtonClick()
    {
        if (UI_Pause_System.isPaused == true)
        {
            UI_Pause_System.isPaused = false;

            //Resumes everything
            Time.timeScale = 1;

            //Close pause panel
            pausePanel.SetActive(false);

            //Re-enables player movement controls
            PlayerMovements.canMove = true;
        }

        else
        {
            Debug.Log("Resume Button is reporting an error! isPaused was flagged as false on click!");
        }
    }
}