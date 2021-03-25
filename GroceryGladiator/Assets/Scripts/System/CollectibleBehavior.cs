using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CollectibleBehavior : MonoBehaviour
{
    public Button inspectButton;
    public Canvas inspectCanvas;
    public Canvas selectionCanvas;
    public GameObject playerObject;
    private float pickupRange = 3.0f;

    void Start()
    {
        selectionCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClick()
    {
        if (Vector3.Distance(playerObject.transform.position, this.gameObject.transform.position) < pickupRange)
        {
            selectionCanvas.gameObject.SetActive(true);
        }
    }
}
