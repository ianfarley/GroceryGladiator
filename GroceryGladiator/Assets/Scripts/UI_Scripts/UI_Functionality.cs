using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Functionality : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("Noel_LevelBlockout");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void QuitToMainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Options ()
    {
        SceneManager.LoadScene("Options Menu");
    }
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
