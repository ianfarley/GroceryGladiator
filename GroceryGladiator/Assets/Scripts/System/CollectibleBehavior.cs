using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleBehavior : MonoBehaviour
{
    public string collectibleName;
    public Button inspectButton;
    public Canvas inspectCanvas;
    public Canvas selectionCanvas;
    public GameObject playerObject;
    private float pickupRange = 2.0f;
    public static bool canPickUp;

    void Start()
    {
        selectionCanvas.gameObject.SetActive(false);
        inspectCanvas.gameObject.SetActive(false);
        this.collectibleName = this.gameObject.name;
        canPickUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickUp && (Vector3.Distance(playerObject.transform.position, this.gameObject.transform.position) < pickupRange))
        {
            inspectCanvas.gameObject.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        if (Vector3.Distance(playerObject.transform.position, this.gameObject.transform.position) < pickupRange)
        {
            selectionCanvas.gameObject.SetActive(true);
        }
    }
}
