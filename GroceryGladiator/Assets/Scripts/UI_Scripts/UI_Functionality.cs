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


}