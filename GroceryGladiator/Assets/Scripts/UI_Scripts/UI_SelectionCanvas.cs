using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SelectionCanvas : MonoBehaviour
{
    public GameObject ingredientObj;
    public Image smallListCross, largeListCross;
    public string objName;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        LevelManager.UpdateLevelCollectibles();
        //Destroy object
        Destroy(this.ingredientObj);
    }

    public void OnResumeClick()
    {
        this.gameObject.SetActive(false);
    }
}
