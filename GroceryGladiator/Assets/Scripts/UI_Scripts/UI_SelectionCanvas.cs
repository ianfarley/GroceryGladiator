using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SelectionCanvas : MonoBehaviour
{
    public GameObject inspectorCanvasObj; //disable inspect canvas after selection
    public Image smallListCross, largeListCross; //used to cross out the proper ingredient
    public GameObject leftObj, midObj, rightObj; //used to "remove" ingredient from the shelf

    public void OnLeftSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        LevelManager.UpdateLevelCollectibles();
        this.gameObject.SetActive(false);
        inspectorCanvasObj.SetActive(false);
        CollectibleBehavior.canPickUp = false;

        //Destroy object
        Destroy(this.leftObj);
    }

    public void OnMidSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        LevelManager.UpdateLevelCollectibles();
        this.gameObject.SetActive(false);
        inspectorCanvasObj.SetActive(false);
        CollectibleBehavior.canPickUp = false;

        //Destroy object
        Destroy(this.midObj);
    }

    public void OnRightSelectionClick()
    {
        //Signal UI to update
        smallListCross.gameObject.SetActive(true);
        largeListCross.gameObject.SetActive(true);
        LevelManager.UpdateLevelCollectibles();
        this.gameObject.SetActive(false);
        inspectorCanvasObj.SetActive(false);
        CollectibleBehavior.canPickUp = false;

        //Destroy object
        Destroy(this.rightObj);
    }

    public void OnResumeClick()
    {
        this.gameObject.SetActive(false);
    }
}
