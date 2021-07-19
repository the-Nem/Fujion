using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public float totalTimeLenth = 90f;
    public float a ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameStatus == false) { return; }
        a = (totalTimeLenth - Time.time);
        Debug.Log("time remining ==" + a);

        if (a <= 0) { GameManager.gameStatus = false; Debug.Log("150 seconds over ! ! !"); }


        //CountTieToDistence();
        //Debug.Log("time remining ==" + (totalTimeLenth - Time.deltaTime));
    }

    private void CountTieToDistence()
    {
       if(totalTimeLenth-Time.deltaTime == 0) { GameManager.gameStatus = false; Debug.Log("150 seconds over ! ! !"); }

    }
}
