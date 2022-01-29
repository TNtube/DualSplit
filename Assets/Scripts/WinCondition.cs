using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public int ReachCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ReachCount == 2)
        {
            Debug.Log("Victoire , changement de scene soon");
        }
    }
}
