using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoLevel : MonoBehaviour
{
    public static float thisLevelTime = 120; //in seconds
    void Start()
    {
        LevelManager.SetTimer(thisLevelTime);
    }

    void Update()
    {
        
    }
}
