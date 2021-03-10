using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Level : MonoBehaviour
{
    public static float thisLevelTime = 120; //in seconds
    void Start()
    {
        LevelManager.SetTimer(thisLevelTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
