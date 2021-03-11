using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Toggle_List : MonoBehaviour
{
    public GameObject miniCheckList;
    public GameObject largeCheckList;

    void Start()
    {
        miniCheckList.SetActive(true);
        largeCheckList.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            miniCheckList.SetActive(!miniCheckList.activeSelf);
            largeCheckList.SetActive(!largeCheckList.activeSelf);
        }
    }
}
