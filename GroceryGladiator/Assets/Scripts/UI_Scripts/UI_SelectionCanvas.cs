using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SelectionCanvas : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObject inspectorCanvasObj; //disable inspect canvas after selection
    public Image smallListCross, largeListCross; //used to cross out the proper ingredient
    public GameObject leftObj, midObj, rightObj, ingredientObj; //used to "remove" ingredient from the shelf
    public bool leftOption, midOption, rightOption;
    public void OnLeftSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        levelManager.GetComponent<LevelManager>().UpdatePlayerCollection(leftOption);
        LevelManager.UpdateLevelCollectibles();
        this.gameObject.SetActive(false);
        ingredientObj.SetActive(true);


        //Destroy object
        Destroy(inspectorCanvasObj);
        Destroy(this.leftObj);
    }

    public void OnMidSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        levelManager.GetComponent<LevelManager>().UpdatePlayerCollection(midOption);
        LevelManager.UpdateLevelCollectibles();
        this.gameObject.SetActive(false);
        ingredientObj.SetActive(true);
        

        //Destroy object
        Destroy(inspectorCanvasObj);
        Destroy(this.midObj);
    }

    public void OnRightSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        levelManager.GetComponent<LevelManager>().UpdatePlayerCollection(rightOption);
        LevelManager.UpdateLevelCollectibles();
        this.gameObject.SetActive(false);
        ingredientObj.SetActive(true);


        //Destroy object
        Destroy(inspectorCanvasObj);
        Destroy(this.rightObj);
    }

    public void OnResumeClick()
    {
        this.gameObject.SetActive(false);
    }
}
