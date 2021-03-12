using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UI_QuitButton : MonoBehaviour
{
    public Button quitButton;
    void Start()
    {
        Button btn = quitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}
