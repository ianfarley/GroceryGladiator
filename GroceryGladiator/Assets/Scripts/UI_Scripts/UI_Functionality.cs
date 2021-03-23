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
        SceneManager.LoadScene("Noel_LevelBlockout2");
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

    public void Sound()
    {
        SceneManager.LoadScene("Sound Menu");
    }

    public void Display()
    {
        SceneManager.LoadScene("Display Menu");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
